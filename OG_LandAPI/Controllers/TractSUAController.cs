using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helpers;
using OG_LandAPI.Models;
using OG_LandAPI.Models.zPagination;
using OG_LandAPI.Repositories;
using OG_LandAPI.Intefaces.Generics;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractSUAController : ControllerBase
        , IPaginationRepository<TractsSuaconnection>
        , IQueryRepository<TractsSuaconnection>
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;
        private readonly TractsSuaConnectionRepository _tractsSuaConnectionRepository;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractSUAController (
             OGDatabaseSchemaV2Context context
           , TractsSuaConnectionRepository tractsSuaConnectionRepository
           )
        {
            _context = context;
            _tractsSuaConnectionRepository = tractsSuaConnectionRepository;
        }

        #region IQUERYREPOSITORY

        ///*  CHOOSE TO IMPLEMENT CODE VIA TractsSuaConnectionRepository  */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("GetByID/{id}")]
        public async Task<ActionResult<IEnumerable<TractsSuaconnection>>> GetById(int Id)
            => await _context.TractsSuaconnection.ToListAsync(); //await ((IQueryRepository<TractsSuaconnection>)_tractsSuaConnectionRepository).GetById(Id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet/*("RetrieveAll")*/]
        public async Task<ActionResult<List<TractsSuaconnection>>> RetrieveAll()
            => await _context.TractsSuaconnection.ToListAsync(); //await ((IQueryRepository<TractsSuaconnection>)_tractsSuaConnectionRepository).RetrieveAll();

        #endregion IQUERYREPOSITORY

        #region IPAGINATIONREPOSITORY

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        [HttpGet("RetrieveByPageN/")]
        public async Task<ActionResult<List<TractsSuaconnection>>> RetrieveByPageN([FromQuery] PaginationDTO T) {
            var Queryable = _context.TractsSuaconnection.AsQueryable();
            await HttpContext.InsertPaginationParamInResponse(Queryable, T.QuantityPerPage);
            return await Queryable.Paginate(T).ToListAsync();
        }

        #endregion IPAGINATIONREPOSITORY 

        #region CUSTOM QUERIES
        
        /// TODO: DECIDE ON WHETHER TO MOVE CODE IMPLEMENTATION TO THE REPO OR JUST LEAVE HERE. CLEANER CONTROLLER IF MOVED!!!
        /// TODO: CHECK THE COMMAND REPO METHODS TO MOVE AS WELL. 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("AllTractsSuaconnections")]
        public async Task<ActionResult<List<TractsSuaconnection>>> AllTractsSuaconnections()
            => await _context.TractsSuaconnection.ToListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        /// TODO: FIX ASYNC ISSUES {WORKAROUND}[REPLACE WITH: " => (IEnumerable<TractsSuaconnection>)await _context.TractsSuaconnection.ToListAsync();" ]
        [HttpGet("SearchAllTractsSuaconnectionByTractId/{TractId}")]
        public async Task<IEnumerable<TractsSuaconnection>> SearchAllTractsSuaconnectionByTractId(string TractId) {
            IQueryable<TractsSuaconnection> query = _context.TractsSuaconnection;
            if (!string.IsNullOrEmpty(TractId)) { 
                query = query.Where(TractsSuaconnection => TractsSuaconnection.TractId.Contains(TractId)); 
            } //|| e.CountyName.Contains(countyname)
            if (TractId != null) { 
                query = query.Where(TractsSuaconnection => TractsSuaconnection.TractId == TractId); 
            }
            
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SUAId"></param>
        /// <returns></returns>
        /// TODO: FIX ASYNC ISSUES {WORKAROUND}[REPLACE WITH: " => await _tractsSuaConnectionRepository.RetrieveAllTractsSuaconnectionsBySuaId(SUAId);" ]
        [HttpGet("SearchAllTractsSuaconnectionBySUAId/{SUAId}")]
        public async Task<IEnumerable<TractsSuaconnection>> SearchAllTractsSuaconnectionBySUAId(string SuaId) {
            IQueryable<TractsSuaconnection> query = _context.TractsSuaconnection;
            if (!string.IsNullOrEmpty(SuaId)) { 
                query = query.Where( TractsSuaconnection => TractsSuaconnection.SuaId.Contains(SuaId)); 
            } //|| e.CountyName.Contains(countyname)
            if (SuaId != null) { 
                query = query.Where(TractsSuaconnection => TractsSuaconnection.SuaId == SuaId); 
            }
            
            return query.ToList();
        }

        #endregion CUSTOM QUERIES

        #region COMMAND REPOSITORY - PER TRACT

        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpPost("POST")]
        public async Task<ActionResult<TractsSuaconnection>> CreateNewByTractID(TractsSuaconnection tractSuaconn) {
            try {
                // LETS CLIENT KNOW IT WAS A BAD REQUEST
                if (tractSuaconn == null) { return BadRequest(); }
                // HAVE TO USE A NON-INTERFACE REPO CLASS IN ORDER TO USE THE NECESSARY CONSTRUCTOR
                var createdByTract = await _tractsSuaConnectionRepository.Create(tractSuaconn);
                // USING CREATEDATACTION/NAMEOF ALLOWS YOU SWAP METHODS EASILY
                return CreatedAtAction(nameof(GetById), new { id = createdByTract.Id }, createdByTract);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<TractsSuaconnection>> UpdateByTractID(int Id, string TractId, TractsSuaconnection tractSuaconn) {
            try {
                if (Id != tractSuaconn.Id) { return BadRequest("Tract ID is a mismatch"); }
                var UpdateByTract = await _tractsSuaConnectionRepository.GetById(Id);
                if (UpdateByTract == null) { return NotFound($"Tract with TractID = {TractId} not found"); }
                return await _tractsSuaConnectionRepository.Update(tractSuaconn);
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data to the database");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TractsSuaconnection>> DeleteTractSUAByTractID(int Id, /*string TractId,*/ TractsSuaconnection tractSuaconn)
            => await _tractsSuaConnectionRepository.Delete(Id, tractSuaconn);

        //{
        //    try
        //    {
        //        var SUAToDelete = await _tractsSuaConnectionRepository.GetById(TractId);
        //        if (SUAToDelete == null) { return NotFound($"Tract with TractID = {TractId} not found"); }
        //        return await _tractsSuaConnectionRepository.Delete(tract);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error deletung data from the database");
        //    }
        //}

        #endregion COMMAND REPOSITORY - PER TRACT

        #region COMMAND REPOSITORY - PER SUA 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        //[HttpPost("POST")]
        //public async Task<ActionResult<TractsSuaconnection>> CreateNewBySuaID(TractsSuaconnection T)
        //{
        //    try
        //    {
        //        // LETS CLIENT KNOW IT WAS A BAD REQUEST
        //        if (T == null) { return BadRequest(); }
        //        // HAVE TO USE A NON-INTERFACE REPO CLASS IN ORDER TO USE THE NECESSARY CONSTRUCTOR
        //        var createdBySUA = await _tractsSuaConnectionRepository.Create(T);
        //        // USING CREATEDATACTION/NAMEOF ALLOWS YOU SWAP METHODS EASILY
        //        return CreatedAtAction(nameof(GetById), new { id = createdBySUA.SuaId }, createdBySUA);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from the database");
        //    }
        //}


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="county"></param>
        ///// <returns></returns>
        //[HttpPut("{id:int}")]
        //public async Task<ActionResult<TractsSuaconnection>> UpdateBySuaID(int T, TractsSuaconnection T2)
        //{
        //    try
        //    {
        //        if (T != T2.Id) { return BadRequest("SUA ID is a mismatch"); }
        //        var UpdateBySua = await _tractsSuaConnectionRepository.GetById(T);
        //        if (UpdateBySua == null) { return NotFound($"SUA with SuaID = {T} not found"); }
        //        return await _tractsSuaConnectionRepository.Update(T2);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error updating data to the database");
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="county"></param>
        ///// <returns></returns>
        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult<TractsSuaconnection>> DeleteTractSUABySuaID(int SuaId, TractsSuaconnection sua)
        //{
        //    try
        //    {
        //        var SUAToDelete = await _tractsSuaConnectionRepository.GetById(SuaId);
        //        if (SUAToDelete == null) { return NotFound($"SUA with SuaID = {SuaId} not found"); }
        //        return await _tractsSuaConnectionRepository.Delete(sua);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error deletung data from the database");
        //    }
        //}

        #endregion COMMAND REPOSITORY - PER SUA 
    }
}
