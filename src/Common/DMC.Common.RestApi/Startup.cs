using System;
using DMC.Common.RestApi.Extensions;
using DMC.Common.RestApi.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DMC.Common.RestApi
{
    public class Startup : IStartup
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            return services
                .AddCustomOptions(_hostingEnvironment)
                .AddCustomAutoMapper()
                .AddCustomRouting()
                .AddCustomSwagger()
                .AddHttpContextAccessor()
                .AddCustomMvcCore(builder =>
                    builder
                        .AddApiExplorer()
                        .AddCustomMvcOptions()
                        .AddCustomJsonOptions(_hostingEnvironment)
                )
                .ToAutofacServiceProvider(builder =>
                    builder
                        .RegisterModules()
                        .AddAutoMapperBuildCallback(_hostingEnvironment)
                );
        }

        public void Configure(IApplicationBuilder app)
        {
            app
                .UseExceptionHandlerMiddleware()
                .UseSwagger()
                .UseSwaggerUI(opt =>
                {
                    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Wrapper Rest Api");
                    opt.RoutePrefix = string.Empty;
                })
                .UseMvc();
        }
    }
}