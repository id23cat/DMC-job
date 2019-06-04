using Autofac;
using Autofac.Extensions.DependencyInjection;
using DMC.Common.RestApi;
using DMC.Weka.Operations.Implementations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace DMC.Weka.Wrapper
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .ConfigureServices(services => services.AddAutofac(builder => builder
                    .RegisterModule<OperationsImplementationsModule>()))
                .UseStartup<Startup>()
                .ConfigureLogging(cfg => cfg.SetMinimumLevel(LogLevel.Warning))
                .Build()
                .Run();
        }
    }
}