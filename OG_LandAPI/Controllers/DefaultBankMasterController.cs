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
    public class DefaultBankMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DefaultBankMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL BANKS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<DefaultBankMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DefaultBankMasters>>> RetrieveAllDefaultBanks()
        {
            return await _context.DefaultBankMasters.ToListAsync();

        }


        /// <summary>
        /// BY BANKS TABLE ID
        /// </summary>
        [HttpGet("GetAllDefaultBanks/{id}")]
        public async Task<ActionResult<DefaultBankMasters>> GetAllDefaultBanks(int id)
        {
            var defaultBankMasters = await _context.DefaultBankMasters.FindAsync(id);

            if (defaultBankMasters == null)
            {
                return NotFound();
            }

            return defaultBankMasters;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllDefaultBanks}")]
        public async Task<IEnumerable<DefaultBankMasters>> SearchAllDefaultBanks(string name)
        {
            try
            {
                var result = await SearchAllDefaultBanks(name);

                if (result.Any())
                {
                    return (IEnumerable<DefaultBankMasters>)Ok(result);
                }

                return (IEnumerable<DefaultBankMasters>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DefaultBankMasters>)StatusCode(StatusCodes.Status500InternalServerError,
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
