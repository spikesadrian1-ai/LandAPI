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
    public class NewPaymentController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public NewPaymentController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewPayment>>> RetrieveAllNewPayment()
        {
            return await _context.NewPayment.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetNewPaymentByID/{id}")]
        public async Task<ActionResult<NewPayment>> GetNewPaymentByID(int id)
        {
            var newPayment = await _context.NewPayment.FindAsync(id);

            if (newPayment == null)
            {
                return NotFound();
            }

            return newPayment;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllNewPayment/{name}")]
        public async Task<IEnumerable<NewPayment>> SearchAllNewPayment(string name)
        {
            try
            {
                var result = await SearchAllNewPayment(name);

                if (result.Any())
                {
                    return (IEnumerable<NewPayment>)Ok(result);
                }

                return (IEnumerable<NewPayment>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<NewPayment>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
