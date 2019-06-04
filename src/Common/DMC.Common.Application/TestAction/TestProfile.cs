using AutoMapper;
using DMC.Common.Infrastructure.Common;
using DMC.Common.Infrastructure.Common.Services;

namespace DMC.Common.Application.TestAction
{
    internal class TestProfile : Profile
    {
        private readonly SafeInjection<ISafeServiceResolver> _safeInjection;
        
        public TestProfile(SafeInjection<ISafeServiceResolver> safeInjection)
        {
            _safeInjection = safeInjection;
            CreateMap<Test, TestResponse>()
                .ForMember(d => d.TestProperty, o => o.MapFrom(s => s.TestAutoMapper));
        }
    }
}