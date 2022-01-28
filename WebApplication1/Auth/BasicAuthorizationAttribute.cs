using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Auth
{
    public class BasicAuthorizationAttribute : AuthorizeAttribute
    {
        public BasicAuthorizationAttribute()
        {
            Policy = "BasicAuthentication";
        }
    }
}
