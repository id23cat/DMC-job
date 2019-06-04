using System.Collections.Generic;
using System.Linq;

namespace DMC.Common.Infrastructure.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<TEntity>(this IEnumerable<TEntity> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }
    }
}