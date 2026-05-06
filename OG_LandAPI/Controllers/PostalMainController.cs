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
    public class PostalMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public PostalMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostalMainForm>>> RetrieveAllPostals()
        {
            return await _context.PostalMainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetAllPostalsByID/{id}")]
        public async Task<ActionResult<PostalMainForm>> GetAllPostalsByID(int id)
        {
            var postalMainForm = await _context.PostalMainForm.FindAsync(id);

            if (postalMainForm == null)
            {
                return NotFound();
            }

            return postalMainForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllPostals/{name}")]
        public async Task<IEnumerable<PostalMainForm>> SearchAllPostals(string name)
        {
            try
            {
                var result = await SearchAllPostals(name);

                if (result.Any())
                {
                    return (IEnumerable<PostalMainForm>)Ok(result);
                }

                return (IEnumerable<PostalMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<PostalMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
