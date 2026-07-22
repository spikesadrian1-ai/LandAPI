using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OG_LandAPI.Models;

namespace OG_LandAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerAddressesMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public OwnerAddressesMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL OWNERS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<OwnerDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnerAddressesMain>>> RetrieveOwnerAddressesMain()
        {
            return await _context.OwnerAddressesMain.ToListAsync();

        }


        /// <summary>
        /// BY OWNER TABLE ID
        /// </summary>
        [HttpGet("GetOwnerAddressesMain/{id}")]
        public async Task<ActionResult<OwnerAddressesMain>> GetOwnerAddressesMain(int id)
        {
            var ownerAddressesMain = await _context.OwnerAddressesMain.FindAsync(id);

            if (ownerAddressesMain == null)
            {
                return NotFound();
            }

            return ownerAddressesMain;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchOwnerAddressesMain/{name}")]
        public async Task<IEnumerable<OwnerAddressesMain>> SearchOwnerAddressesMain(string name)
        {
            IQueryable<OwnerAddressesMain> query = _context.OwnerAddressesMain;

            try
            {
                //IQueryable<CountyMasterMainForm> query = _context.CountyMasterMainForm;

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(e => e.OwnerId.Contains(name)
                                     //|| e.CountyName.Contains(countyname)
                                     );

                }
                if (name != null)
                {
                    query = query.Where(e => e.OwnerId == name);
                }

                //return query.ToList();
            }
            catch (Exception)
            {
                return (IEnumerable<OwnerAddressesMain>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }

            return (IEnumerable<OwnerAddressesMain>)query.ToList();
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
