﻿using System;
using AutoMapper;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.ViewModels.Input;
using EQS.AccessControl.Application.ViewModels.Output;
using EQS.AccessControl.Application.ViewModels.Output.Base;
using EQS.AccessControl.Domain.Entities;
using EQS.AccessControl.Domain.Interfaces.Services;

namespace EQS.AccessControl.Application.Services
{
    public class LoginAppService : ILoginAppService
    {
        private readonly ILoginService _loginService;

        public LoginAppService(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void Dispose()
        {
            _loginService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ResponseModelBase<LoginOutput> Login(CredentialInput credential)
        {
            var credentialModel = Mapper.Map<Credential>(credential);

            var result = _loginService.Login(credentialModel);

            var personOutput = Mapper.Map<LoginOutput>(result);

            return new ResponseModelBase<LoginOutput>().OkResult(personOutput, result.Validations.ErrorMessages);
        }
    }
}
