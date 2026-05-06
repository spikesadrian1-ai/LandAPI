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
    public class RegionsMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public RegionsMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        //private readonly ILogger<CountyMasterController> _logger;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="logger"></param>
        //public CountyMasterController(ILogger<CountyMasterController> logger)
        //{
        //    _logger = logger;
        //}



        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegionMasterMainForm>>> RetrieveAllRegions()
        {
            return await _context.RegionMasterMainForm.ToListAsync();

        }


        ///// <summary>
        ///// BY Burdens TABLE ID
        ///// </summary>
        //[HttpGet("GetCountiesByID/{id}")]
        //public async Task<ActionResult<RegionMasterMainForm>> GetCountiesByID(int id)
        //{
        //    var regionMasterMain = await _context.RegionMasterMainForm.FindAsync(id);

        //    if (regionMasterMain == null)
        //    {
        //        return NotFound();
        //    }

        //    return regionMasterMain;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllRegions/{name}")]
        public async Task<IEnumerable<RegionMasterMainForm>> SearchAllRegions(string name/*, FormationCodes formationCodes*/)
        {
            //IQueryable<RegionMasterMainForm> query = _context.RegionMasterMainForm;

            //if (!string.IsNullOrEmpty(name))
            //{
            //    query = query.Where(e => e.Region.Contains(name));  // OR STARTSWITH, ENDSWITH
            //        //|| e.ColumnName.Contains(name));
            //}

            ////// OPTIONAL: USED WHEN MORE THAN ONE PARAM
            ////if (!Param !null)
            ////{
            ////    query = query.Where(e => e.FormationCodes == formationCodes);
            ////}

            ////    FIX ERROR
            //return await query.ToList(); 



            try
            {
                var result = await SearchAllRegions(name);

                if (result.Any())
                {
                    return (IEnumerable<RegionMasterMainForm>)Ok(result);
                }

                return (IEnumerable<RegionMasterMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<RegionMasterMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }

        //// POST: RegionsMasterController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RegionsMasterController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RegionsMasterController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RegionsMasterController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RegionsMasterController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
