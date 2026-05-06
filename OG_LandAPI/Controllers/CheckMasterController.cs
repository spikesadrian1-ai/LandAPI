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
    public class CheckMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public CheckMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL CHECKS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CheckDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckMasterMainForm>>> RetrieveAllChecks()
        {
            return await _context.CheckMasterMainForm.ToListAsync();

        }


        /// <summary>
        /// BY CHECKS TABLE ID
        /// </summary>
        [HttpGet("GetAllChecks/{id}")]
        public async Task<ActionResult<CheckMasterMainForm>> GetAllChecks(int id)
        {
            var checkMasterMainForm = await _context.CheckMasterMainForm.FindAsync(id);

            if (checkMasterMainForm == null)
            {
                return NotFound();
            }

            return checkMasterMainForm;
        }


        /// <summary>
        ///  BY CHECKS NAME
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllChecks}/{name}")]
        public async Task<IEnumerable<CheckMasterMainForm>> SearchAllChecks(string name)
        {
            try
            {
                var result = await SearchAllChecks(name);

                if (result.Any())
                {
                    return (IEnumerable<CheckMasterMainForm>)Ok(result);
                }

                return (IEnumerable<CheckMasterMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<CheckMasterMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
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
