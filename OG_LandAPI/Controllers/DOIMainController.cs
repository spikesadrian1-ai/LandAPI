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
    public class DOIMainController : ControllerBase
    {

        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DOIMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoimainForm>>> RetrieveAllMainDOIs()
        {
            return await _context.DoimainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetMainDOIsByID/{id}")]
        public async Task<ActionResult<DoimainForm>> GetMainDOIsByID(int id)
        {
            var DoimainForm = await _context.DoimainForm.FindAsync(id);

            if (DoimainForm == null)
            {
                return NotFound();
            }

            return DoimainForm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllMainDOIs/{name}")]
        public async Task<IEnumerable<DoimainForm>> SearchAllMainDOIs(string name)
        {
            try
            {
                var result = await SearchAllMainDOIs(name);

                if (result.Any())
                {
                    return (IEnumerable<DoimainForm>)Ok(result);
                }

                return (IEnumerable<DoimainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DoimainForm>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }

        //// POST: DOIMainController/Create
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

        //// GET: DOIMainController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    //return View();
        //}

        //// POST: DOIMainController/Edit/5
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

        //// GET: DOIMainController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: DOIMainController/Delete/5
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
