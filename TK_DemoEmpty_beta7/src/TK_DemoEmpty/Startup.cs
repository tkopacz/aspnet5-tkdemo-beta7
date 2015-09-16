using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace TK_DemoEmpty
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseErrorPage();
            app.UseStaticFiles();
            app.UseFileServer(new Microsoft.AspNet.StaticFiles.FileServerOptions() { EnableDirectoryBrowsing = true,RequestPath=@"C:\TMP" });
            app.Run(async (context) =>
            {
                throw new Exception("Błąd!");
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
