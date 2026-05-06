using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using Microsoft.EntityFrameworkCore;
using OG_LandAPI.Models.zPagination;
using WebAPI.Helpers;
using OG_LandAPI.Intefaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractMainFormsController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;
        private readonly ITractMainRepository tractMainRepository; 

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractMainFormsController(OGDatabaseSchemaV2Context context/*, Repositories.ITractMainRepository tractMainRepository*/)
        {
            _context = context;
            this.tractMainRepository = tractMainRepository;
        }


        /// <summary>
        /// ALL OWNERS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<TractMainFormsController>
        [HttpGet]
        public async Task<ActionResult<List<TractMainForm>>> RetrieveAllTracts(/*[FromQuery] PaginationDTO pagination*/)
        {
            //var Queryable = _context.TractMainForm.AsQueryable();
            //await HttpContext.InsertPaginationParamInResponse(Queryable, pagination.QuantityPerPage);
            //return await Queryable.Paginate(pagination).ToListAsync();

            return await _context.TractMainForm.ToListAsync();
        }


        /// <summary>
        /// BY TRACT TABLE ID
        /// </summary>
        [HttpGet("GetTractsByID/{id}")]
        public async Task<ActionResult<TractMainForm>> GetTractsByID(int id)
        {
            var tractMainForm = await _context.TractMainForm.FindAsync(id);

            if (tractMainForm == null)
            {
                return NotFound();
            }

            return tractMainForm;

            ////  OR FOR USE WITH A INT
            //return await _context.CountyMasterMainForm
            //    .FirstOrDefaultAsync(e => e.Id == id);


            //// OR FOR USE WITH A STRING
            //return await _context.CountyMasterMainForm
            //  .FirstOrDefaultAsync(e => e.CountyId == id);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllTracts/{name}")]
        //public async Task<List<TractMainForm>> SearchAllTracts(string name)
        //  OR  public List<TractMainForm> SearchAllTracts(string name)
        public async Task<List<TractMainForm>> SearchAllTracts(string name)
        {

            IQueryable<TractMainForm> query = _context.TractMainForm;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.TractId.Contains(name)
                                 //|| e.CountyName.Contains(countyname)
                                 );

            }
            if (name != null)
            {
                query = query.Where(e => e.TractId == name);
            }

            //return query.ToList();
            return await Task.FromResult(query.ToList());

            ////  OR

            //return await this._context.TractMainForm.Where(x => x.TractId.Contains(name, StringComparison.OrdinalIgnoreCase) ||
            //    string.IsNullOrWhiteSpace(name)).ToListAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TractMainForm>> CreateNewTract(TractMainForm tractMainForm)
        {
            //return Ok();

            try
            {
                if (tractMainForm == null)
                {
                    // LETS CLIENT KNOW IT WAS A BAD REQUEST
                    return BadRequest();
                }

                // HAVE TO USE A NON-INTERFACE REPO CLASS IN ORDER TO USE THE NECESSARY CONSTRUCTOR
                var createdNewTract = await tractMainRepository.AddNewTract(tractMainForm);

                // USING CREATEDATACTION/NAMEOF ALLOWS YOU SWAP METHODS EASILY
                return CreatedAtAction(nameof(GetTractsByID), new { id = createdNewTract.TractId }, createdNewTract);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tract"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<TractMainForm>> UpdateTract(string TractID, TractMainForm tractMainForm)
        {
            try
            {
                if (TractID != tractMainForm.TractId)
                {
                    return BadRequest("Tract ID is a mismatch");
                }

                var tractToUpdate = await tractMainRepository.GetTractsByID(TractID);

                if (tractToUpdate == null)
                {
                    return NotFound($"Tract with TractID = {TractID} not found");
                }

                return await tractMainRepository.UpdateTract(tractMainForm);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data to the database");
            }

            ////  OR

            //var tract = await this._context.TractMainForm.FindAsync(tractMainForm.TractId);
            //if (tract != null)
            //{
            //    tract.TractId = tractMainForm.TractId;
            //    tract.FullDescription = tractMainForm.FullDescription;
            //    // CONTINUE WITH REST OF CLASS PROPERTIES

            //    await _context.SaveChangesAsync();
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractID"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TractMainForm>> DeleteTract(string TractID, TractMainForm tractMainForm)
        {
            try
            {
                var tractToDelete = await tractMainRepository.GetTractsByID(TractID);

                if (tractToDelete == null)
                {
                    return NotFound($"Tract with ID = {TractID} not found");
                }

                return await tractMainRepository.DeleteTract(tractMainForm);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data from the database");
            }
        }

    }
    



}
