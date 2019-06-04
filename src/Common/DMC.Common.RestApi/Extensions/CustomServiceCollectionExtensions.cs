using System;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using DMC.Common.Infrastructure.Common.ApplicationSettings;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace DMC.Common.RestApi.Extensions
{
    public static class CustomServiceCollectionExtensions
    {
        /// <summary>
        /// Adds services ti DI container for mvc core
        /// </summary>
        /// <param name="services">DI services collection</param>
        /// <param name="builder">Builder for custom configuring mvc core</param>
        public static IServiceCollection AddCustomMvcCore(
            this IServiceCollection services,
            Action<IMvcCoreBuilder> builder)
        {
            builder(services.AddMvcCore());
            return services;
        }

        /// <summary>
        /// Adds services
        /// </summary>
        /// <param name="services">DI services collection</param>
        /// <param name="builderConfig"></param>
        /// <returns></returns>
        public static AutofacServiceProvider ToAutofacServiceProvider(
            this IServiceCollection services,
            Action<ContainerBuilder> builderConfig)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builderConfig(builder);
            return builder.ToServiceProvider();
        }

        public static IServiceCollection AddCustomOptions(
            this IServiceCollection services,
            IHostingEnvironment hostingEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", true)
                .AddJsonFile("appsettings.Personal.json", true)
                .AddEnvironmentVariables();

            RegisterConfigurations(builder.Build(), services);

            return services;
        }

        private static void RegisterConfigurations(IConfigurationRoot configs, IServiceCollection services)
        {
            services.AddSingleton(configs.GetSection(nameof(DataBaseConfigurations)).Get<DataBaseConfigurations>());
        }

        public static IServiceCollection AddCustomRouting(this IServiceCollection services)
        {
            return services.AddRouting(options => { options.LowercaseUrls = true; });
        }

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info {Title = "Wrapper Rest Api", Version = "v1"});

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

        public static IServiceCollection AddCustomAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(provider.GetServices<Profile>());
            }));
            services.AddSingleton(provider => provider.GetService<MapperConfiguration>().CreateMapper());

            return services;
        }
    }
}