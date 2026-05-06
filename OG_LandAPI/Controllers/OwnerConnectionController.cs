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
    public class OwnerConnectionController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public OwnerConnectionController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnerConnection>>> RetrieveAllOwnerConnections()
        {
            return await _context.OwnerConnection.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetOwnerConnectionsByID/{id}")]
        public async Task<ActionResult<OwnerConnection>> GetOwnerConnectionsByID(int id)
        {
            var ownerConnection = await _context.OwnerConnection.FindAsync(id);

            if (ownerConnection == null)
            {
                return NotFound();
            }

            return ownerConnection;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllOwnerConnections/{name}")]
        public async Task<IEnumerable<OwnerConnection>> SearchAllOwnerConnections(string name)
        {
            try
            {
                var result = await SearchAllOwnerConnections(name);

                if (result.Any())
                {
                    return (IEnumerable<OwnerConnection>)Ok(result);
                }

                return (IEnumerable<OwnerConnection>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<OwnerConnection>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
