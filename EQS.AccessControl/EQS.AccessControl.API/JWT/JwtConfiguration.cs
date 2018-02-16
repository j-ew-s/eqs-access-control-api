using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EQS.AccessControl.API.JWT.Interface;

namespace EQS.AccessControl.API.JWT
{
    public class JwtConfiguration : IJwtConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
