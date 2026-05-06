using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using OG_LandAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class COTController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public COTController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL COTs (CHAIN OF TITLE)
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<COTController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChainOfTitleForm>>> RetrieveAllCOTs()
        {
            return await _context.ChainOfTitleForm.ToListAsync();

        }


        /// <summary>
        /// BY COTs TABLE ID
        /// </summary>
        [HttpGet("GetAllCOTs/{id}")]
        public async Task<ActionResult<ChainOfTitleForm>> GetAllCOTs(int id)
        {
            var chainOfTitleForm = await _context.ChainOfTitleForm.FindAsync(id);

            if (chainOfTitleForm == null)
            {
                return NotFound();
            }

            return chainOfTitleForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllCOTs}/{name}")]
        public async Task<IEnumerable<ChainOfTitleForm>> SearchAllCOTs(string name)
        {
            try
            {
                var result = await SearchAllCOTs(name);

                if (result.Any())
                {
                    return (IEnumerable<ChainOfTitleForm>)Ok(result);
                }

                return (IEnumerable<ChainOfTitleForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<ChainOfTitleForm>)StatusCode(StatusCodes.Status500InternalServerError,
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
