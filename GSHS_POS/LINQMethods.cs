using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GSHS_POS
{
    public static class LINQMethods
    {
        public static IQueryable<TSource>
            GenericEvaluateOrderBy<TSource>(this IQueryable<TSource> query, string orderbyName, bool orderDesc = false)
        {
            string order = (orderDesc) ? "OrderByDescending" : "OrderBy";
            var type = typeof(TSource);
            var parameter = Expression.Parameter(type, "p");
            var propertyReference = Expression.Property(parameter, orderbyName);
            var sortExpression = Expression.Call(
                    typeof(Queryable),
                    order,
                    new Type[] { type },
                    null,
                    Expression.Lambda<Func<TSource, bool>>(propertyReference, new[] { parameter })
                );
            return query.Provider.CreateQuery<TSource>(sortExpression);
        }

        public static IQueryable<T>
            GenericWhere<T>(this IQueryable<T> query, Dictionary<string, dynamic> whereClause, bool AndOr)
        {
            var type = typeof(T);
            ParameterExpression pe = Expression.Parameter(type, "p");
            return null;
        }
    }
}
