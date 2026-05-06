using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class SpecialProvisionsRepository : ISpecialProvisionsRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public SpecialProvisionsRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisions()
        {
            return await _context.SpecialProvisions.ToListAsync();
        }

        public async Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByLeaseId(string LeaseId)
        {
            return await _context.SpecialProvisions.ToListAsync();
        }

        public async Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByTractId(string TractId)
        {
            return await _context.SpecialProvisions.ToListAsync();
        }
    }
}
