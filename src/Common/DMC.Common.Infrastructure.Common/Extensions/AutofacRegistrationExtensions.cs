using System;
using Autofac;

namespace DMC.Common.Infrastructure.Common.Extensions
{
    public static class AutofacRegistrationExtensions
    {
        public static ContainerBuilder
            ScopedAsImplementedInterfaces<TConcrete>(this ContainerBuilder builder)
        {
            builder.RegisterType<TConcrete>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            return builder;
        }

        public static ContainerBuilder SingleAs<TConcrete, TAs>(this ContainerBuilder builder)
        {
            builder.RegisterType<TConcrete>()
                .As<TAs>()
                .SingleInstance();

            return builder;
        }
        
        public static ContainerBuilder SingleAsSelf<TConcrete>(this ContainerBuilder builder)
        {
            builder.RegisterType<TConcrete>()
                .AsSelf()
                .SingleInstance();

            return builder;
        }

        public static ContainerBuilder ScopedFactoryAsSelf<TConcrete>(
            this ContainerBuilder builder,
            Func<IComponentContext, TConcrete> factory)
        {
            builder.Register(factory)
                .AsSelf()
                .SingleInstance();

            return builder;
        }
    }
}