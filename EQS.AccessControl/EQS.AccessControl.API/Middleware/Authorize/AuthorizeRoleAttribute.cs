using Microsoft.AspNetCore.Authorization;

namespace EQS.AccessControl.API.Authorize
{
    public class AuthorizeRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeRoleAttribute(params string[] roles) : base()
        {
            Roles = string.Join(",", roles);
        }
    }
}
