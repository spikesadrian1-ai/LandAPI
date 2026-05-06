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
    public class SurfaceOwnershipController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public SurfaceOwnershipController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<SurfaceOwnership>>> RetrieveAllSurfaceOwnership(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.CountyMasterMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.SurfaceOwnership.ToListAsync();
        }


        [HttpGet("SearchAllSurfaceOwnershipByTractId/{TractId}")]
        public async Task<IEnumerable<SurfaceOwnership>> SearchAllSurfaceOwnershipByTractId(string TractId)
        {
            IQueryable<SurfaceOwnership> query = _context.SurfaceOwnership;
            if (!string.IsNullOrEmpty(TractId)) { query = query.Where(e => e.TractId.Contains(TractId)); }
            //|| e.CountyName.Contains(countyname)
            if (TractId != null) { query = query.Where(e => e.TractId == TractId); }
            return query.ToList();
        }


        [HttpGet("SearchAllSurfaceOwnershipByLeaseId/{LeaseId}")]
        public async Task<IEnumerable<SurfaceOwnership>> SearchAllSurfaceOwnershipByLeaseId(string LeaseId)
        {
            IQueryable<SurfaceOwnership> query = _context.SurfaceOwnership;
            if (!string.IsNullOrEmpty(LeaseId)) { query = query.Where(e => e.TractId.Contains(LeaseId)); }
            //|| e.CountyName.Contains(countyname)
            if (LeaseId != null) { query = query.Where(e => e.LeaseId == LeaseId); }
            return query.ToList();
        }


    }
}
