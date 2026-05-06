using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using OG_LandAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EasementMainFormController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public EasementMainFormController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        
        /// <summary>
        /// ALL OWNERS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<OwnerDetailsController>     
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EasementMainForm>>> GetAllEasements()
        {
            return await _context.EasementMainForm.ToListAsync();

            //try
            //{
            //    return Ok(await easementRepository.GetAllEasements());

            //}
            //catch (Exception)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //        "Error 500");
            //}

        }


        /// <summary>
        /// BY EASEMENTS TABLE ID
        /// </summary>
        [HttpGet("GetEasementBy/{id}")]
        public async Task<ActionResult<EasementMainForm>> GetEasementBy(int id)
        {
            var easementMainForm = await _context.EasementMainForm.FindAsync(id);

            if (easementMainForm == null)
            {
                return NotFound();
            }

            return easementMainForm;

            //try
            //{
            //    return Ok(await easementRepository.GetEasementByID());
            //    //var result = await easementRepository.GetEasementByID(id);

            //    //if (result == null)
            //    //{
            //    //    return NotFound();
            //    //}

            //    // Allowing the mixing  between a repository and a controller
            //    //return (ActionResult<EasementMainFormController>)result;

            //}
            //catch (Exception)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //        "Error 500");
            //}
        }



        [HttpPost]
        //public async Task<ActionResult<EasementMainForm>> CreateNewEasement(EasementMainForm easementMainForm) 
        public ActionResult<EasementMainForm> CreateNewEasement(EasementMainForm easementMainForm)
        {
            if (easementMainForm is null)
            {
                throw new ArgumentNullException(nameof(easementMainForm));
            }

            return Ok();
        }






    }
}
