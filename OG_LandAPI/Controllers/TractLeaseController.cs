using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using Microsoft.EntityFrameworkCore;
using OG_LandAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractLeaseController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;
        //private readonly ITractLeaseConnectionRepository _tractLeaseConnectionRepository;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractLeaseController(
            OGDatabaseSchemaV2Context context
            //,ITractLeaseConnectionRepository tractLeaseConnectionRepository
            )
        {
            _context = context;
            //_tractLeaseConnectionRepository = tractLeaseConnectionRepository;
        }
        

        [HttpGet]
        public async Task<ActionResult<List<TractsLeaseConnection>>> RetrieveAllTractLeases(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.CountyMasterMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.TractsLeaseConnection.ToListAsync();
        }

        
        //[HttpGet("GetTractLeasesByTractID/{TractId}")]
        //public async Task<ActionResult<TractsLeaseConnection>> GetTractsLeaseConnectionsByTractID(string TractId) {
        //    var tractsLeaseConnection = await _context.TractsLeaseConnection.FindAsync(TractId);
        //    if (tractsLeaseConnection == null) { return NotFound(); }
        //    return tractsLeaseConnection;
        //}

        
        [HttpGet("SearchAllTractLeasesByTractId/{TractId}")]
        public async Task<IEnumerable<TractsLeaseConnection>> SearchAllTractLeasesByTractId(string TractId) {

            IQueryable<TractsLeaseConnection> query = _context.TractsLeaseConnection;

            if (!string.IsNullOrEmpty(TractId)) { query = query.Where(e => e.TractId.Contains(TractId)); }//|| e.CountyName.Contains(countyname)

            if (TractId != null) { query = query.Where(e => e.TractId == TractId); }

            return query.ToList();
        }


    }
}
