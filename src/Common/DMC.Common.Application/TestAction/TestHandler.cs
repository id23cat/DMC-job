using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using JetBrains.Annotations;
using MediatR;

namespace DMC.Common.Application.TestAction
{
    [UsedImplicitly]
    internal class TestHandler : IRequestHandler<TestRequest, TestResponse>
    {
        private readonly IMapper _mapper;

        public TestHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<TestResponse> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_mapper.Map<TestResponse>(new Test
            {
                TestAutoMapper = "rere"
            }));
        }
    }
}