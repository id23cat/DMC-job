using System.Threading.Tasks;
using DMC.Common.Application.TestAction;
using DMC.Common.RestApi.Attributes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DMC.Common.RestApi.Controllers
{
    [ApiRoute]
    public class TestController : BaseApiController
    {
        public TestController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<TestResponse> GetResponse()
        {
            return await Mediator.Send(new TestRequest());
        }
    }
}