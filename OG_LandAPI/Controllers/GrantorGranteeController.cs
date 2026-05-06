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
    public class GrantorGranteeController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public GrantorGranteeController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL GrantorsGrantees
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<GrantorGranteeController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrantorsGrantees>>> RetrieveAllGrantorsGrantees()
        {
            return await _context.GrantorsGrantees.ToListAsync();

        }


        /// <summary>
        /// BY GrantorsGrantees TABLE ID
        /// </summary>
        [HttpGet("GetBurdens/{id}")]
        public async Task<ActionResult<GrantorsGrantees>> GetAllGrantorsGrantees(int id)
        {
            var burdens = await _context.GrantorsGrantees.FindAsync(id);

            if (burdens == null)
            {
                return NotFound();
            }

            return burdens;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllGrantorsGrantees}")]
        public async Task<IEnumerable<GrantorsGrantees>> SearchAllGrantorsGrantees(string name)
        {
            try
            {
                var result = await SearchAllGrantorsGrantees(name);

                if (result.Any())
                {
                    return (IEnumerable<GrantorsGrantees>)Ok(result);
                }

                return (IEnumerable<GrantorsGrantees>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<GrantorsGrantees>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }


        //public async Task<OwnerAddressesMain> AddOwner(OwnerAddressesMain ownerAddressesMain)
        //{
        //    var result = await OGDatabaseSchemaV2Context.OwnerAddressesMain.AddAsync(ownerAddressesMain);
        //    await OGDatabaseSchemaV2Context
        //}


        //public async Task<IEnumerable<IOwnerRepository>> SearchOwners(string name, string tractid)
        // {


        // }

        //public async Task<IEnumerable<OwnerAddressesMain>> SearchOwners(string name, string tractid)
        ////async Task<IEnumerable<OwnerAddressesMain>> IOwnerRepository.SearchOwners(string name, string tractid)
        //{
        //    IQueryable<OwnerAddressesMain> query = _context.OwnerAddressesMain;

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.FullName.Contains(name)
        //                         || e.TractId.Contains(tractid));

        //    }
        //    if (tractid != null)
        //    {
        //        query = query.Where(e => e.TractId == tractid);
        //    }

        //    return await query.ToList();
        //}

        //async Task<object> IOwnerRepository.SearchOwners1(string name, string tractid)
        //{
        //    IQueryable<OwnerAddressesMain> query = _context.OwnerAddressesMain;

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.FullName.Contains(name)
        //                         || e.TractId.Contains(tractid));

        //    }
        //    if (tractid != null)
        //    {
        //        query = query.Where(e => e.TractId == tractid);
        //    }

        //    return await query.ToList();
        //}
    }
}
