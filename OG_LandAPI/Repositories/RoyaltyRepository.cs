using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class RoyaltyRepository : IRoyaltyRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public RoyaltyRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Royalty>> RetrieveAllRoyalties()
        {
            return await _context.Royalty.ToListAsync();
        }

        public async Task<IEnumerable<Royalty>> SearchAllRoyaltiesByLeaseId(string LeaseId)
        {
            return await _context.Royalty.ToListAsync();
        }

        public async Task<IEnumerable<Royalty>> SearchAllRoyaltiesByTractId(string TractId)
        {
            return await _context.Royalty.ToListAsync();
        }
    }
}
