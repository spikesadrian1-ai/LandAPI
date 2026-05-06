using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialObligationController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public SpecialObligationController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<SpecialObligations>>> RetrieveAllSpecialObligations(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.CountyMasterMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.SpecialObligations.ToListAsync();
        }


        [HttpGet("SearchAllSpecialObligationsByTractId/{TractId}")]
        public async Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByTractId(string TractId)
        {
            IQueryable<SpecialObligations> query = _context.SpecialObligations;
            if (!string.IsNullOrEmpty(TractId)) { query = query.Where(e => e.TractId.Contains(TractId)); }
            //|| e.CountyName.Contains(countyname)
            if (TractId != null) { query = query.Where(e => e.TractId == TractId); }
            return query.ToList();
        }


        [HttpGet("SearchAllSpecialObligationsByLeaseId/{LeaseId}")]
        public async Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByLeaseId(string LeaseId)
        {
            IQueryable<SpecialObligations> query = _context.SpecialObligations;
            if (!string.IsNullOrEmpty(LeaseId)) { query = query.Where(e => e.TractId.Contains(LeaseId)); }
            //|| e.CountyName.Contains(countyname)
            if (LeaseId != null) { query = query.Where(e => e.LeaseId == LeaseId); }
            return query.ToList();
        }


    }
}
