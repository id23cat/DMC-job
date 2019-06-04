using System;
using System.Reflection;
using Autofac;
using AutoMapper;
using DMC.Common.Application.TestAction;
using DMC.Common.Infrastructure.Common.Extensions;
using MediatR;
using Module = Autofac.Module;

namespace DMC.Common.Application
{
    public class ApplicationModule : Module
    {
        private static readonly Type[] MediatrOpenTypes =
        {
            typeof(IRequestHandler<,>),
            typeof(INotificationHandler<>),
        };
        
        protected override void Load(ContainerBuilder builder)
        {
            foreach (Type mediatrOpenType in MediatrOpenTypes)
            {
                builder
                    .RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                    .AsClosedTypesOf(mediatrOpenType)
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();
            }

            builder
                .ScopedAsImplementedInterfaces<Mediator>()
                .ScopedFactoryAsSelf<ServiceFactory>(ctx => ctx.Resolve<IComponentContext>().Resolve);

//            builder.SingleAs<TestProfile, Profile>();
        }
    }
}