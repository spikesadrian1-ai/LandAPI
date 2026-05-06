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
    public class CheckDetailsController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public CheckDetailsController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL CHECK DETAILS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CheckDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckDetails>>> RetrieveAllCheckDetails()
        {
            return await _context.CheckDetails.ToListAsync();

        }


        /// <summary>
        /// BY Check Details TABLE ID
        /// </summary>
        [HttpGet("GetAllCheckDetails/{id}")]
        public async Task<ActionResult<CheckDetails>> GetAllCheckDetails(int id)
        {
            var checkDetails = await _context.CheckDetails.FindAsync(id);

            if (checkDetails == null)
            {
                return NotFound();
            }

            return checkDetails;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllCheckDetails}/{name}")]
        public async Task<IEnumerable<CheckDetails>> SearchAllCheckDetails(string name)
        {
            try
            {
                var result = await SearchAllCheckDetails(name);

                if (result.Any())
                {
                    return (IEnumerable<CheckDetails>)Ok(result);
                }

                return (IEnumerable<CheckDetails>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<CheckDetails>)StatusCode(StatusCodes.Status500InternalServerError,
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
