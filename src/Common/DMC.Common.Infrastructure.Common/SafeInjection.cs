using DMC.Common.Infrastructure.Common.Services;

namespace DMC.Common.Infrastructure.Common
{
    public class SafeInjection<TService>
    {
        private readonly ISafeServiceResolver _safeServiceResolver;

        public SafeInjection(ISafeServiceResolver safeServiceResolver)
        {
            _safeServiceResolver = safeServiceResolver;
        }

        public TService Value => _safeServiceResolver.GetService<TService>();
    }
}