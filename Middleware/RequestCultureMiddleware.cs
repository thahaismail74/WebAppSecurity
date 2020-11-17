using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;
namespace WebAppSecurity
{
    public class RequestCultureMiddleware
    {
        private RequestDelegate _next;
        public RequestCultureMiddleware (RequestDelegate next)
        {
            _next = next;

        }
        public async Task InvokeAsync (HttpContext context)
        {

            var culture = context.Request.Query["culture"];
            if (!string.IsNullOrEmpty(culture))
            {
                var mycultureinfo = new CultureInfo(culture);
                CultureInfo.CurrentCulture = mycultureinfo;
                CultureInfo.CurrentUICulture = mycultureinfo;

            }
            await _next.Invoke(context);
        }
    }
}
