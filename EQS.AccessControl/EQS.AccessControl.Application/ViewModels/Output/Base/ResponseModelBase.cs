using System.Collections.Generic;
using System.Net;

namespace EQS.AccessControl.Application.ViewModels.Output.Base
{
    public class ResponseModelBase<TEntity>
    {
        public List<TEntity> Payload { get; set; }
        public HttpStatusCode Status { get; set; }
        public int ResultLength { get; set; }
        public List<string> Message { get; set; }
        public bool Error { get; set; }

        public ResponseModelBase<TEntity> OkResult(List<TEntity> payload, List<string> message)
        {
            return new ResponseModelBase<TEntity>
            {
                Payload = payload,
                Status = HttpStatusCode.OK,
                ResultLength = payload.Count,
                Message = message,
                Error = message.Count >= 1
            };
        }

        public ResponseModelBase<TEntity> Exception(TEntity payload,  string message)
        {
            return new ResponseModelBase<TEntity>
            {
                Payload = new List<TEntity> { payload },
                Status = HttpStatusCode.InternalServerError,
                ResultLength = 1,
                Message = new List<string>() { message},
                Error = true
            };
        }

    }
}
