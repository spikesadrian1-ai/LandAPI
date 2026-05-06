using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Repositories
{
    public class TractOwnershipRepository : ITractOwnershipRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractOwnershipRepository(OGDatabaseSchemaV2Context context) => _context = context;


        public async Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnerships() 
            => await _context.TractOwnership.ToListAsync();

        
        public async Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByLeaseId(string LeaseId) 
            => await _context.TractOwnership.ToListAsync();

        
        public async Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByTractId(string TractId) 
            => await _context.TractOwnership.ToListAsync();

    }
}
