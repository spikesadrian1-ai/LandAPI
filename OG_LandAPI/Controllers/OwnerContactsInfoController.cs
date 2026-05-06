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
    public class OwnerContactsInfoController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public OwnerContactsInfoController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnersContactInfo>>> RetrieveAllCounties()
        {
            return await _context.OwnersContactInfo.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetOwnersContactInfoByID/{id}")]
        public async Task<ActionResult<OwnersContactInfo>> GetOwnersContactInfoByID(int id)
        {
            var ownersContactInfo = await _context.OwnersContactInfo.FindAsync(id);

            if (ownersContactInfo == null)
            {
                return NotFound();
            }

            return ownersContactInfo;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllOwnersContactInfo/{name}")]
        public async Task<IEnumerable<OwnersContactInfo>> SearchAllOwnersContactInfo(string name)
        {
            try
            {
                var result = await SearchAllOwnersContactInfo(name);

                if (result.Any())
                {
                    return (IEnumerable<OwnersContactInfo>)Ok(result);
                }

                return (IEnumerable<OwnersContactInfo>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<OwnersContactInfo>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
