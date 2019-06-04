using System;
using DMC.Common.Infrastructure.Common.Services;
using Microsoft.AspNetCore.Http;

namespace DMC.Common.RestApi.Middleware
{
    public class AutofacMiddlewareFactory : IMiddlewareFactory
    {
        private readonly ISafeServiceResolver _serviceResolver;

        public AutofacMiddlewareFactory(ISafeServiceResolver serviceResolver)
        {
            _serviceResolver = serviceResolver;
        }

        public IMiddleware Create(Type middlewareType)
        {
            return (IMiddleware)_serviceResolver.GetService(middlewareType);
        }

        public void Release(IMiddleware middleware)
        {
        }
    }
}