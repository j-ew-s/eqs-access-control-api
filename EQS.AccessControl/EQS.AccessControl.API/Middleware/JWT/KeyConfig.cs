using System.Security.Cryptography;
using EQS.AccessControl.API.JWT.Interface;
using Microsoft.IdentityModel.Tokens;

namespace EQS.AccessControl.API.JWT
{
    public class KeyConfig : IKeyConfig
    {
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentials { get; }

        public KeyConfig()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials(
                Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
