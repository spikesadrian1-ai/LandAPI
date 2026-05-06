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
    public class PropertyTractController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public PropertyTractController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyTractConnection>>> RetrieveAllPropertyTractConnections()
        {
            return await _context.PropertyTractConnection.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetPropertyTractConnectionsByID/{id}")]
        public async Task<ActionResult<PropertyTractConnection>> GetPropertyTractConnectionsByID(int id)
        {
            var propertyTractConnection = await _context.PropertyTractConnection.FindAsync(id);

            if (propertyTractConnection == null)
            {
                return NotFound();
            }

            return propertyTractConnection;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllPropertyTractConnections/{name}")]
        public async Task<IEnumerable<PropertyTractConnection>> SearchAllPropertyTractConnections(string name)
        {
            try
            {
                var result = await SearchAllPropertyTractConnections(name);

                if (result.Any())
                {
                    return (IEnumerable<PropertyTractConnection>)Ok(result);
                }

                return (IEnumerable<PropertyTractConnection>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<PropertyTractConnection>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
