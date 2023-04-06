using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace QuarterlySalesApp.Models.ExtensionMethods
{
    public static class QueryExtensions
    {
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, 
                                              int pageNumber, int pageSize)
        {
            return query
                .Skip(pageNumber - 1 * pageSize)
                .Take(pageSize);
        }
    }
}
