using System.Collections.Generic;
using System.Linq;
using DirWatchTransfer.Core.DB;
using DirWatchTransfer.Core.SignalR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DirWatchTransfer.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            using (DirWatchTransferContext context = new DirWatchTransferContext())
            {
                List<string> pendingMigrations = context.Database.GetPendingMigrations().ToList();

                if (pendingMigrations.Count != 0)
                {
                    context.Database.Migrate();
                }
            }

            services.AddSignalR();
            services.AddRepositories();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSignalR((options) =>
            {
                options.MapHub<FileSystemHub>("/hub");
            });
        }
    }
}
