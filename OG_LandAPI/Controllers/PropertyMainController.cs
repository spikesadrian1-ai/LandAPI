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
    public class PropertyMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public PropertyMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyMainForm>>> RetrieveAllProperties()
        {
            return await _context.PropertyMainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetPropertiesByID/{id}")]
        public async Task<ActionResult<PropertyMainForm>> GetPropertiesByID(int id)
        {
            var propertyMainForm = await _context.PropertyMainForm.FindAsync(id);

            if (propertyMainForm == null)
            {
                return NotFound();
            }

            return propertyMainForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllProperties/{name}")]
        public async Task<IEnumerable<PropertyMainForm>> SearchAllProperties(string name)
        {
            try
            {
                var result = await SearchAllProperties(name);

                if (result.Any())
                {
                    return (IEnumerable<PropertyMainForm>)Ok(result);
                }

                return (IEnumerable<PropertyMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<PropertyMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
