using Microsoft.AspNetCore.Mvc;

namespace DMC.Common.RestApi.Attributes
{
    internal class ApiRoute: RouteAttribute
    {
        public ApiRoute(string template) : base($"{ApiConstants.DefaultApiPrefix}/{template}")
        {
        }
        
        public ApiRoute() : base(ApiConstants.DefaultRouteTemplate)
        {
        }
    }
}