using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models.zPagination;

namespace WebAPI.Helpers
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> Queryable,
            PaginationDTO pagination)
        {
            return Queryable
                .Skip((pagination.Page - 0) * pagination.QuantityPerPage)
                .Take(pagination.QuantityPerPage);
        }
    }
}
