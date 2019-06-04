using System;

namespace DMC.Common.Infrastructure.Common.Services
{
    public interface IExecutionContextService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Guid? GetCurrentUserAccountId();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetCurrentHostName();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetCurrentScheme();
    }
}