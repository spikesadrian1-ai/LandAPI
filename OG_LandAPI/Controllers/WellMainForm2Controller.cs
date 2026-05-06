using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellMainForm2Controller : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public WellMainForm2Controller(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }




        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WellMainForm2>>> RetrieveAllWells()
        {
            return await _context.WellMainForm2.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetWellsByID/{id}")]
        public async Task<ActionResult<WellMainForm2>> GetWellsByID(int id)
        {
            var WellMainForm2 = await _context.WellMainForm2.FindAsync(id);

            if (WellMainForm2 == null)
            {
                return NotFound();
            }

            return WellMainForm2;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllWells/{name}")]
        public async Task<IEnumerable<WellMainForm2>> SearchAllWells(string name)
        {
            try
            {
                var result = await SearchAllWells(name);

                if (result.Any())
                {
                    return (IEnumerable<WellMainForm2>)Ok(result);
                }

                return (IEnumerable<WellMainForm2>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<WellMainForm2>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
