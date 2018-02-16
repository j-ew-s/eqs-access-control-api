using System;
using System.Collections.Generic;
using System.Text;
using EQS.AccessControl.Application.ViewModels.Output.Register;

namespace EQS.AccessControl.Application.ViewModels.Output
{
    public class LoginOutput
    {
        public string Token { get; set; }
        public RegisterPersonOutput PersonOutput { get; set; }
    }
}
