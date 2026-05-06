using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using Microsoft.EntityFrameworkCore;
using OG_LandAPI.Models.zPagination;
using WebAPI.Helpers;
using OG_LandAPI.Intefaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountyMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;
        //private readonly ICountyRepository _countyRepository;
        private readonly ICountyRepository _countyRepository;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public CountyMasterController(OGDatabaseSchemaV2Context context
            , ICountyRepository countyRepository)
        {
            _context = context;
            _countyRepository = countyRepository;
        }


        //private readonly ILogger<CountyMasterController> _logger;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="logger"></param>
        //public CountyMasterController(ILogger<CountyMasterController> logger)
        //{
        //    _logger = logger;
        //}


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<List<CountyMasterMainForm>>> RetrieveAllCounties([FromQuery] PaginationDTO pagination)
        {
            var Queryable = _context.CountyMasterMainForm.AsQueryable();
            await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            return await Queryable.Paginate(pagination).ToListAsync();
            
            //return await _context.CountyMasterMainForm.ToListAsync();
        }  


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetCountiesByID/{id}")]
        public async Task<ActionResult<CountyMasterMainForm>> GetCountiesByID(int id)
        {
            var countyMasterMain = await _context.CountyMasterMainForm.FindAsync(id);

            if (countyMasterMain == null)
            {
                return NotFound();
            }

            return countyMasterMain;

            ////  OR FOR USE WITH A INT
            //return await _context.CountyMasterMainForm
            //    .FirstOrDefaultAsync(e => e.Id == id);


            //// OR FOR USE WITH A STRING
            //return await _context.CountyMasterMainForm
            //  .FirstOrDefaultAsync(e => e.CountyId == id);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllCounties/{name}")]
        public async Task<IEnumerable<CountyMasterMainForm>> SearchAllCounties(string name) {            
            IQueryable<CountyMasterMainForm> query = _context.CountyMasterMainForm;
            if (!string.IsNullOrEmpty(name)) { query = query.Where(e => e.CountyName.Contains(name)); }
            if (name != null) { query = query.Where(e => e.CountyName == name); }
            return query.ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpPost("POST")]
        public async Task<ActionResult<CountyMasterMainForm>> CreateNewCounty(CountyMasterMainForm county) {
            try {
                // LETS CLIENT KNOW IT WAS A BAD REQUEST
                if (county == null) { return BadRequest(); }
                // HAVE TO USE A NON-INTERFACE REPO CLASS IN ORDER TO USE THE NECESSARY CONSTRUCTOR
                var createdNewCounty = await _countyRepository.AddNewCounty(county);
                // USING CREATEDATACTION/NAMEOF ALLOWS YOU SWAP METHODS EASILY
                return CreatedAtAction(nameof(GetCountiesByID), new { id = createdNewCounty.CountyId }, createdNewCounty);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<CountyMasterMainForm>> UpdateCounty(string CountyID, CountyMasterMainForm county) {
            try {
                if (CountyID != county.CountyId) { return BadRequest("County ID is a mismatch"); }
                var countyToUpdate = await _countyRepository.GetCountiesByID(CountyID);
                if (countyToUpdate == null) { return NotFound($"County with CountyID = {CountyID} not found"); }
                return await _countyRepository.UpdateCounty(county);
            } catch (Exception) { 
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data to the database"); 
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CountyMasterMainForm>> DeleteCounty(string CountyID, CountyMasterMainForm county) {
            try {
                var countyToDelete = await _countyRepository.GetCountiesByID(CountyID);
                if (countyToDelete == null) { return NotFound($"County with ID = {CountyID} not found"); }
                return await _countyRepository.DeleteCounty(county);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deletung data from the database");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        ////public async Task<OwnerAddressesMain> AddOwner(CountyMasterMainForm county) // TODO: FIX
        //public async Task<object> AddNewCounty(CountyMasterMainForm county)
        //{
        //    var result = await _context.CountyMasterMainForm.AddAsync(county);
        //    await _context.SaveChangesAsync();
        //    return result.Entity;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        //public async Task<object> DeleteCounty(int ID)
        //public async void DeleteCounty(string countyID)
        //{
        //    var result = await _context.CountyMasterMainForm
        //        .FirstOrDefaultAsync(e => e.CountyId == countyID);
        //    if (result != null) 
        //    {
        //        _context.CountyMasterMainForm.Remove(result);
        //        await _context.SaveChangesAsync();
        //    }
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyID"></param>
        /// <returns></returns>
        //public async Task<object> UpdateCounty(CountyMasterMainForm county)
        ////public async void UpdateCounty(CountyMasterMainForm county)
        ////public async Task<CountyMasterMainForm> UpdateCounty(CountyMasterMainForm county)
        //{
        //    var result = await _context.CountyMasterMainForm
        //        .FirstOrDefaultAsync(e => e.CountyId == county.CountyId);

        //    if (result != null)
        //    {
        //        //result.Id = county.Id;
        //        //result.CountyId = county.CountyId;
        //        result.CountyName = county.CountyName;
        //        result.StateId = county.StateId;

        //        await _context.SaveChangesAsync();

        //        return result;
        //    }

        //    return null;
        //}
    }
}
