using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EQS.AccessControl.API.JWT.Interface;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.API.JWT
{
    public class TokenGenerator : ITokenGenerator
    {
        private readonly IJwtConfiguration _tokenConfiguration;
        private readonly IKeyConfig _keyConfig;

        public TokenGenerator(IJwtConfiguration tokenConfiguration, IKeyConfig keyConfig)
        {
            _tokenConfiguration = tokenConfiguration ?? throw new ArgumentNullException(nameof(tokenConfiguration));
            _keyConfig = keyConfig ?? throw new ArgumentNullException(nameof(keyConfig));
        }

        public ResponseModelBase<LoginOutput> CreateToken(LoginOutput login)
        {
            var dataCriacao = DateTime.UtcNow;
            var dataExpiracao = dataCriacao + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, login.PersonOutput.Id.ToString()),
                new Claim(ClaimTypes.Name, login.PersonOutput.Name)
            };

            foreach (var role in login.PersonOutput.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            var token = new JwtSecurityToken(
                _tokenConfiguration.Issuer,
                _tokenConfiguration.Audience,
                claims,
                dataCriacao,
                dataExpiracao,
                _keyConfig.SigningCredentials);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            login.Token = jwt;

            return  new ResponseModelBase<LoginOutput>().OkResult(login, new List<string>()) ;
        }
    }
}
