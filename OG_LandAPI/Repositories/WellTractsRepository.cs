using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class WellTractsRepository : IWellTractsRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public WellTractsRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WellTractsConnection>> RetrieveAllWellTractsConnections()
        {
            return await _context.WellTractsConnection.ToListAsync();
        }

        public async Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByTractId(string TractId)
        {
            return await _context.WellTractsConnection.ToListAsync();
        }

        public async Task<IEnumerable<WellTractsConnection>> SearchAllWellTractsConnectionsByWellId(string WellId)
        {
            return await _context.WellTractsConnection.ToListAsync();
        }
    }
}
