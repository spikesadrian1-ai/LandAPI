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
    public class ROWMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public ROWMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RowMainForm>>> RetrieveAllROWs()
        {
            return await _context.RowMainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetROWsByID/{id}")]
        public async Task<ActionResult<RowMainForm>> GetROWsByID(int id)
        {
            var rowMainForm = await _context.RowMainForm.FindAsync(id);

            if (rowMainForm == null)
            {
                return NotFound();
            }

            return rowMainForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllROWs/{name}")]
        public async Task<IEnumerable<RowMainForm>> SearchAllROWs(string name)
        {
            try
            {
                var result = await SearchAllROWs(name);

                if (result.Any())
                {
                    return (IEnumerable<RowMainForm>)Ok(result);
                }

                return (IEnumerable<RowMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<RowMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
