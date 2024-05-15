using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application
{
    public class ClassTest(IHttpContextAccessor context, IConfiguration configuration) : IClassTest
    {
        public void test()
        {
            var a = context.HttpContext.Request.Headers["Authorization"];
            var test = configuration.GetSection("ConnectionStrings:Dev").Value;
            var b = context.HttpContext.Request.Headers["Authorization"];
            //var cookieOptions = new CookieOptions
            //{
                
            //};
            context.HttpContext.Response.Cookies.Append("test", "test_cookie");
            context.HttpContext.Request.Headers["Authorization"] = a;
        }
    }
}
