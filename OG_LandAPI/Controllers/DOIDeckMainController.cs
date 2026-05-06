using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DOIDeckMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DOIDeckMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }



        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoideckMain>>> RetrieveAllDoiDecks()
        {
            return await _context.DoideckMain.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetDoiDecksByID/{id}")]
        public async Task<ActionResult<DoideckMain>> GetDoiDecksByID(int id)
        {
            var DoideckMain = await _context.DoideckMain.FindAsync(id);

            if (DoideckMain == null)
            {
                return NotFound();
            }

            return DoideckMain;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllDoiDecks/{name}")]
        public async Task<IEnumerable<DoideckMain>> SearchAllDoiDecks(string name)
        {
            try
            {
                var result = await SearchAllDoiDecks(name);

                if (result.Any())
                {
                    return (IEnumerable<DoideckMain>)Ok(result);
                }

                return (IEnumerable<DoideckMain>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DoideckMain>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }

        //// POST: DOIDeckMainController/Create
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
        //        //return View();
        //    }
        //}

        //// GET: DOIDeckMainController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    //return View();
        //}

        //// POST: DOIDeckMainController/Edit/5
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

        //// GET: DOIDeckMainController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: DOIDeckMainController/Delete/5
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
