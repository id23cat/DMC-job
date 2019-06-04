namespace DMC.Common.RestApi
{
    public static class ApiConstants
    {
        public static readonly string DefaultApiPrefix = "api";
        
        public static readonly string DefaultRouteTemplate = $"{DefaultApiPrefix}/[controller]";
        
        public const string DefaultResponseContentType = "application/json";
    }
}