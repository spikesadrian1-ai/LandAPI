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
    public class DraftMasterMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DraftMasterMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL Drafts
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<DraftMasterMainController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DraftMasterMain>>> RetrieveAllDrafts()
        {
            return await _context.DraftMasterMain.ToListAsync();

        }


        /// <summary>
        /// BY Drafts TABLE ID
        /// </summary>
        [HttpGet("GetAllDrafts/{id}")]
        public async Task<ActionResult<DraftMasterMain>> GetAllDrafts(int id)
        {
            var drafts = await _context.DraftMasterMain.FindAsync(id);

            if (drafts == null)
            {
                return NotFound();
            }

            return drafts;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllDrafts}")]
        public async Task<IEnumerable<DraftMasterMain>> SearchAllDrafts(string name)
        {
            try
            {
                var result = await SearchAllDrafts(name);

                if (result.Any())
                {
                    return (IEnumerable<DraftMasterMain>)Ok(result);
                }

                return (IEnumerable<DraftMasterMain>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DraftMasterMain>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }

            //  OR TO CUT DOWN ON LINES OF CODE PRETTY COOL
            //try
            //{
            //    IEnumerable<DraftMasterMain> result = await SearchAllDrafts(name);
            //    return result.Any() ? (IEnumerable<DraftMasterMain>)Ok(result) : (IEnumerable<DraftMasterMain>)NotFound();
            //}
            //catch (Exception)
            //{ return (IEnumerable<DraftMasterMain>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database"); }
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
