using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertPaginationParamInResponse<T>(this HttpContext httpContext,
            IQueryable<T> Queryable, int RecordsPerPage)
        {
            double Count = await Queryable.CountAsync();
            double PgQuantity = Math.Ceiling(Count / RecordsPerPage);
            httpContext.Response.Headers.Add("PgQuantity", PgQuantity.ToString());
        }
    }
}
