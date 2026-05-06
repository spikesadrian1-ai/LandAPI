using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helpers;
using OG_LandAPI.Models;
using OG_LandAPI.Models.zPagination;
using OG_LandAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractOwnershipController : ControllerBase //, ITractOwnershipRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractOwnershipController(OGDatabaseSchemaV2Context context) // => _context = context; 
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<TractOwnership>>> RetrieveAllTractOwnership(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.CountyMasterMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.TractOwnership.ToListAsync();
        }


        [HttpGet("SearchAllTractOwnershipByTractId/{TractId}")]
        public async Task<IEnumerable<TractOwnership>> SearchAllTractOwnershipByTractId(string TractId) {

            IQueryable<TractOwnership> query = _context.TractOwnership;

            if (!string.IsNullOrEmpty(TractId)) 
            { query = query.Where(TractOwnership => TractOwnership.TractId.Contains(TractId)); } //|| e.CountyName.Contains(countyname)
            
            if (TractId != null) {  query = query.Where(/*async*/ TractOwnership => /*await*/ TractOwnership.TractId == TractId); }

            return query.ToList();
        }


        [HttpGet("SearchAllTractOwnershipByLeaseId/{LeaseId}")]
        public async Task<IEnumerable<TractOwnership>> SearchAllTractOwnershipByLeaseId(string LeaseId) {

            IQueryable<TractOwnership> query = _context.TractOwnership;

            if (!string.IsNullOrEmpty(LeaseId)) 
            { query = query.Where(TractOwnership => TractOwnership.LeaseId.Contains(LeaseId)); } //|| e.CountyName.Contains(countyname)
            
            if (LeaseId != null) { query = query.Where(TractOwnership => TractOwnership.LeaseId == LeaseId); }

            return query.ToList();
        }



        //public async Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnerships([FromQuery] PaginationDTO pagination) {

        //    var Queryable = _context.CountyMasterMainForm.AsQueryable();
        //    await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
        //    return (IEnumerable<TractOwnership>)await Queryable.Paginate(pagination).ToListAsync();
        //}

        //public Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByTractId(string TractId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByLeaseId(string LeaseId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
