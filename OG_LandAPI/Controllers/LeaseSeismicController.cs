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
    public class LeaseSeismicController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public LeaseSeismicController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaseSeismicForm>>> RetrieveAllLeaseSeismic()
        {
            return await _context.LeaseSeismicForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetLeaseSeismicByID/{id}")]
        public async Task<ActionResult<LeaseSeismicForm>> GetLeaseSeismicByID(int id)
        {
            var LeaseSeismicForm = await _context.LeaseSeismicForm.FindAsync(id);

            if (LeaseSeismicForm == null)
            {
                return NotFound();
            }

            return LeaseSeismicForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllLeaseSeismic/{name}")]
        public async Task<IEnumerable<LeaseSeismicForm>> SearchAllLeaseSeismic(string name)
        {
            try
            {
                var result = await SearchAllLeaseSeismic(name);

                if (result.Any())
                {
                    return (IEnumerable<LeaseSeismicForm>)Ok(result);
                }

                return (IEnumerable<LeaseSeismicForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<LeaseSeismicForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
