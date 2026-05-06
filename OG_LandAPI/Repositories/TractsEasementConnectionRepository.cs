using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using OG_LandAPI.Intefaces.Generics;

namespace OG_LandAPI.Repositories
{
    public class TractsEasementConnectionRepository : ControllerBase
                                                     , ICommandRepository<TractsEasementConnection>
    {

        #region 

        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractsEasementConnectionRepository(OGDatabaseSchemaV2Context context) => _context = context;

        #endregion

        #region IQUERYREPOSITORY GENERIC QUERIES

        public async Task<ActionResult<IEnumerable<TractsEasementConnection>>> GetById(int Id)
            => await _context.TractsEasementConnection.ToListAsync();

        #endregion IQUERYREPOSITORY GENERIC QUERIES

        #region COMMANDS

        public async Task<TractsEasementConnection> Create(TractsEasementConnection TractSuaConn)
        {
            var result = await _context.TractsEasementConnection.AddAsync(TractSuaConn);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<TractsEasementConnection> Update(TractsEasementConnection TractSuaConn)
        {
            var result = await _context.TractsEasementConnection
            .FirstOrDefaultAsync(e => e.Id == TractSuaConn.Id && e.TractId == TractSuaConn.TractId);

            if (result != null)
            {
                result.Id = TractSuaConn.Id;
                result.TractId = TractSuaConn.TractId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<ActionResult<TractsEasementConnection>> Delete(int Id, TractsEasementConnection TractSuaConn)
        {
            try
            {
                var tractToDelete = await GetById(Id);
                if (tractToDelete == null) { return NotFound($"Tract with ID = {TractSuaConn} not found"); }

                return await Delete(TractSuaConn);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deletung data from the database");
            }
        }

        public async Task<TractsEasementConnection> Delete(TractsEasementConnection TractSuaConn)
        {
            var result = await _context.TractsEasementConnection
             .FirstOrDefaultAsync(e => e.TractId == e.TractId);

            if (result != null)
            {
                result.Id = TractSuaConn.Id;
                result.TractId = TractSuaConn.TractId;
                result.EasementId = TractSuaConn.EasementId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        #endregion COMMANDS
    }
}
