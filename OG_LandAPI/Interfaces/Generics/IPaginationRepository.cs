using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models.zPagination;

namespace OG_LandAPI.Intefaces.Generics
{
    public interface IPaginationRepository<T>
    {
        Task<ActionResult<List<T>>> RetrieveByPageN([FromQuery] PaginationDTO T);

    }
}
