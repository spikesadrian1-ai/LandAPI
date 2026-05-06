using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OG_LandAPI.Models.zPagination
{
    public class PaginationDTO
    {
        public int Page { get; set; }

        public int QuantityPerPage { get; set; } = 10;
    }
}
