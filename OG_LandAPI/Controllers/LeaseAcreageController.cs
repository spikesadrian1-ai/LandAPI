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
    public class LeaseAcreageController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public LeaseAcreageController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaseAcreageForm>>> RetrieveAllLeaseAcreages()
        {
            return await _context.LeaseAcreageForm.ToListAsync();
        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetLeaseAcreagesByID/{id}")]
        public async Task<ActionResult<LeaseAcreageForm>> GetLeaseAcreagesByID(int id)
        {
            var LeaseAcreageForm = await _context.LeaseAcreageForm.FindAsync(id);

            if (LeaseAcreageForm == null)
            {
                return NotFound();
            }

            return LeaseAcreageForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllLeaseAcreages/{name}")]
        public async Task<IEnumerable<LeaseAcreageForm>> SearchAllLeaseAcreages(string name)
        {
            try
            {
                var result = await SearchAllLeaseAcreages(name);

                if (result.Any())
                {
                    return (IEnumerable<LeaseAcreageForm>)Ok(result);
                }

                return (IEnumerable<LeaseAcreageForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<LeaseAcreageForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
