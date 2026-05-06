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
    public class RecordingInfoController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public RecordingInfoController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecordingInformation>>> RetrieveAllRecordingInformation()
        {
            return await _context.RecordingInformation.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetRecordingInformationByID/{id}")]
        public async Task<ActionResult<RecordingInformation>> GetRecordingInformationByID(int id)
        {
            var recordingInformation = await _context.RecordingInformation.FindAsync(id);

            if (recordingInformation == null)
            {
                return NotFound();
            }

            return recordingInformation;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("SearchAllRecordingInformation/{name}")]
        public async Task<IEnumerable<RecordingInformation>> SearchAllRecordingInformation(string name)
        {
            try
            {
                var result = await SearchAllRecordingInformation(name);

                if (result.Any())
                {
                    return (IEnumerable<RecordingInformation>)Ok(result);
                }

                return (IEnumerable<RecordingInformation>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<RecordingInformation>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }
    }
}
