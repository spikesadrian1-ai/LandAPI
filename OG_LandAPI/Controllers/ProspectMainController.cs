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
    public class ProspectMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public ProspectMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProspectMainForm>>> RetrieveAllProspects()
        {
            return await _context.ProspectMainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetProspectsByID/{id}")]
        public async Task<ActionResult<ProspectMainForm>> GetProspectsByID(int id)
        {
            var ProspectMainForm = await _context.ProspectMainForm.FindAsync(id);

            if (ProspectMainForm == null)
            {
                return NotFound();
            }

            return ProspectMainForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllProspects/{name}")]
        public async Task<IEnumerable<ProspectMainForm>> SearchAllProspects(string name)
        {
            try
            {
                var result = await SearchAllProspects(name);

                if (result.Any())
                {
                    return (IEnumerable<ProspectMainForm>)Ok(result);
                }

                return (IEnumerable<ProspectMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<ProspectMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        //public async Task<OwnerAddressesMain> AddOwner(OwnerAddressesMain ownerAddressesMain)
        public async Task<object> AddNewCounty(ProspectMainForm prospect)
        {
            var result = await _context.ProspectMainForm.AddAsync(prospect);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        //public async Task<object> Deleteprospect(int ID)
        public async void Deleteprospect(string prospectID)
        {
            var result = await _context.ProspectMainForm
                .FirstOrDefaultAsync(e => e.ProspectId == prospectID);
            if (result != null)
            {
                _context.ProspectMainForm.Remove(result);
                await _context.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="prospectID"></param>
        /// <returns></returns>
        public async Task<object> UpdateProspect(ProspectMainForm prospect)
        //public async void Updateprospect(ProspectMainForm prospect)
        //public async Task<ProspectMainForm> Updateprospect(ProspectMainForm prospect)
        {
            var result = await _context.ProspectMainForm
                .FirstOrDefaultAsync(e => e.ProspectId == prospect.ProspectId);

            if (result != null)
            {                
                result.ProspectId = prospect.ProspectId;
                result.Name = prospect.Name;
                result.Status = prospect.Status;
                result.Producing = prospect.Producing;
                result.Active = prospect.Active;
                result.StateId = prospect.StateId;
                result.CountyId = prospect.CountyId;
                result.StateId2 = prospect.StateId2;
                result.CountyId2 = prospect.CountyId;
                result.RegionId = prospect.RegionId;
                result.DistrictId = prospect.DistrictId;
                result.OperatorId = prospect.OperatorId;
                result.LesseeId = prospect.LesseeId;
                result.LandmanId = prospect.LandmanId;
                result.GrossAcres = prospect.GrossAcres;
                result.NetAcres = prospect.NetAcres;
                result.BonusPerAcre = prospect.BonusPerAcre;
                result.TotalBonus = prospect.TotalBonus;
                result.BrokerFeesPerAcre = prospect.BrokerFeesPerAcre;
                result.BrokerFees = prospect.BrokerFees;
                result.OtherCosts = prospect.OtherCosts;
                result.LeasedByUs = prospect.LeasedByUs;
                result.LeasedByOthers = prospect.LeasedByOthers;
                result.UnleasedAndOpen = prospect.UnleasedAndOpen;
                result.Field1 = prospect.Field1;
                result.Field2 = prospect.Field2;
                result.Field3 = prospect.Field3;
                result.Field4 = prospect.Field4;
                result.SpecialProvisionsNotes = prospect.CountyId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
