using System;
using System.Reflection;
using Autofac;
using AutoMapper;
using AutoMapper.Configuration;
using DMC.Common.Infrastructure.Common.Extensions;
using DMC.Common.RestApi.Middleware;
using Microsoft.AspNetCore.Authentication;
using Module = Autofac.Module;

namespace DMC.Common.RestApi
{
    public class WebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .ScopedAsImplementedInterfaces<WebSafeServiceResolver>()
                .ScopedAsImplementedInterfaces<AuthenticationService>()
                .SingleAsSelf<ExceptionHandlerMiddleware>()
                .ScopedAsImplementedInterfaces<AutofacMiddlewareFactory>();

            builder
                .RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AssignableTo<Profile>()
                .Except<MapperConfigurationExpression>()
                .Where(type => !type.IsNestedPrivate)
                .As<Profile>()
                .SingleInstance();
        }
    }
}