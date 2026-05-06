using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class DistrictsMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DistrictsMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL Districts
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<DistrictsMasterController>
        [HttpGet]
        //[AllowAnonymous]
        //public async Task<ActionResult<List<DistrictMasterMain>>> RetrieveAllDistricts()
        public async Task<ActionResult<IEnumerable<DistrictMasterMain>>> RetrieveAllDistricts()
        {
            return await _context.DistrictMasterMain.ToListAsync();

        }


        /// <summary>
        /// BY Districts TABLE ID
        /// </summary>
        [HttpGet("GetAllDistricts/{id}")]   // OR [HttpGet("{id}", Name = "GetDistricts")]
        public async Task<ActionResult<DistrictMasterMain>> GetAllDistricts(int id)
        {
            var districtMaster = await _context.DistrictMasterMain.FindAsync(id);

            if (districtMaster == null)
            {
                return NotFound();
            }

            return districtMaster;

            //  OR

            //  return await _context.DistrictMasterMain.FirstOrDefaultAsync(x => x.Id == id);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllDistricts/{name}")]
        public async Task<IEnumerable<DistrictMasterMain>> SearchAllDistricts(string name)
        {
            try
            {
                var result = await SearchAllDistricts(name);

                if (result.Any())
                {
                    return (IEnumerable<DistrictMasterMain>)Ok(result);
                }

                return (IEnumerable<DistrictMasterMain>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DistrictMasterMain>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }


        
    }
}
