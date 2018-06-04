using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using EQS.AccessControl.Application.ViewModels.Output.Base;

namespace EQS.AccessControl.API.Filters
{
    public class ExceptionHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new JsonResult(PrepareResponseObject(context));
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            base.OnException(context);
            context.ExceptionHandled = true;
        }

        private ResponseModelBase<object> PrepareResponseObject(ExceptionContext context)
        {
           
            return new ResponseModelBase<object>().Exception(new object(), context.Exception.Message);
        }
    }
}
