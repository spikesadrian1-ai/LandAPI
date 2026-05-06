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
    public class WellTractController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public WellTractController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<WellTractsConnection>>> RetrieveAllTractLeases(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.CountyMasterMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.WellTractsConnection.ToListAsync();
        }


        //[HttpGet("GetTractLeasesByTractID/{TractId}")]
        //public async Task<ActionResult<TractsLeaseConnection>> GetTractsLeaseConnectionsByTractID(string TractId) {
        //    var tractsLeaseConnection = await _context.TractsLeaseConnection.FindAsync(TractId);
        //    if (tractsLeaseConnection == null) { return NotFound(); }
        //    return tractsLeaseConnection;
        //}


        [HttpGet("SearchAllTractWellsByWellId/{WellId}")]
        public async Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByWellId(string WellId)
        {
            IQueryable<WellTractsConnection> query = _context.WellTractsConnection;
            if (!string.IsNullOrEmpty(WellId)) { query = query.Where(e => e.TractId.Contains(WellId)); }
            //|| e.CountyName.Contains(countyname)
            if (WellId != null) { query = query.Where(e => e.WellId == WellId); }
            return query.ToList();
        }


        [HttpGet("SearchAllTractWellsByTractId/{TractId}")]
        public async Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByTractId(string TractId)
        {
            IQueryable<WellTractsConnection> query = _context.WellTractsConnection;
            if (!string.IsNullOrEmpty(TractId)) { query = query.Where(e => e.TractId.Contains(TractId)); }
            //|| e.CountyName.Contains(countyname)
            if (TractId != null) { query = query.Where(e => e.TractId == TractId); }
            return query.ToList();
        }
    }
}
