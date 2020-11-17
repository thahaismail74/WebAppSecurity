using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSecurity
{
    public static class RequestCultureMiddleWareExtensions
    {
        public static  IApplicationBuilder UseRequestCulture( this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCultureMiddleware>();

        }
    }
}
