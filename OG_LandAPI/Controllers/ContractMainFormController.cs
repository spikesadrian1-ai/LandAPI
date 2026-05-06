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
    public class ContractMainFormController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public ContractMainFormController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL CHECKS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CheckDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractMainForm2>>> RetrieveAllContracts()
        {
            return await _context.ContractMainForm2.ToListAsync();

        }


        /// <summary>
        /// BY Contracts TABLE ID
        /// </summary>
        [HttpGet("GetAllContracts/{id}")]
        public async Task<ActionResult<ContractMainForm2>> GetAllContracts(int id)
        {
            var contractMainForm2 = await _context.ContractMainForm2.FindAsync(id);

            if (contractMainForm2 == null)
            {
                return NotFound();
            }

            return contractMainForm2;
        }


        /// <summary>
        ///  BY Contracts NAME
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllContracts}/{name}")]
        public async Task<IEnumerable<ContractMainForm2>> SearchAllContracts(string name)
        {
            try
            {
                var result = await SearchAllContracts(name);

                if (result.Any())
                {
                    return (IEnumerable<ContractMainForm2>)Ok(result);
                }

                return (IEnumerable<ContractMainForm2>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<ContractMainForm2>)StatusCode(StatusCodes.Status500InternalServerError,
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
