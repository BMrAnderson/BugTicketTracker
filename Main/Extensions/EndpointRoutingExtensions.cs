using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Extensions
{
    public static class EndpointRoutingExtensions
    {
        public static IApplicationBuilder ConfigureEndpointRouting(this IApplicationBuilder builder)
        {
            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=LogIn}/{id?}");

                endpoints.MapControllerRoute(
                    name: "index",
                    pattern: "{controller=Account}/{action=Register}/{id?}");
            });

            //Add new endpoints here
            
            return builder;
        }
    }
}
