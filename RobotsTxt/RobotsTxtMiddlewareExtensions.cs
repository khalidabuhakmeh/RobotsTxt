using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace RobotsTxt
{
    public static class RobotsTxtMiddlewareExtensions
    {
        public static IApplicationBuilder UseRobotsTxt(
            this IApplicationBuilder builder,
            IWebHostEnvironment env,
            string rootPath = null
        )
        {
            return builder.MapWhen(ctx => ctx.Request.Path.StartsWithSegments("/robots.txt"), b =>
                b.UseMiddleware<RobotsTxtMiddleware>(env.EnvironmentName, rootPath ?? env.ContentRootPath ));
        }
    }
}