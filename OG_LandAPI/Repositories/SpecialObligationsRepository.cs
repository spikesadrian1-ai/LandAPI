using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class SpecialObligationsRepository : ISpecialObligationsRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public SpecialObligationsRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SpecialObligations>> RetrieveAllSpecialObligations()
        {
            return await _context.SpecialObligations.ToListAsync();
        }

        public async Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByLeaseId(string LeaseId)
        {
            return await _context.SpecialObligations.ToListAsync();
        }

        public async Task<IEnumerable<SpecialObligations>> SearchAllSpecialObligationsByTractId(string TractId)
        {
            return await _context.SpecialObligations.ToListAsync();
        }
    }
}
