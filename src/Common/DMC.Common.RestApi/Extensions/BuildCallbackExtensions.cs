using System;
using Autofac;
using AutoMapper;
using DMC.Common.Application;
using DMC.Common.Domain.Services;
using DMC.Common.Infrastructure.Common;
using Microsoft.AspNetCore.Hosting;

namespace DMC.Common.RestApi.Extensions
{
    public static class AutofacRegistrationExtensions
    {
        public static ContainerBuilder RegisterModules(this ContainerBuilder builder)
        {
            builder
                .RegisterModule<WebApiModule>()
                .RegisterModule<ApplicationModule>()
                .RegisterModule<DomainServicesModule>()
                .RegisterModule<InfrastructureCommonModule>();

            return builder;
        }

        public static ContainerBuilder AddAutoMapperBuildCallback(this ContainerBuilder builder,
            IHostingEnvironment hostingEnvironment)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                builder.RegisterBuildCallback(container =>
                    container.Resolve<MapperConfiguration>().AssertConfigurationIsValid());
            }

            return builder;
        }
    }
}