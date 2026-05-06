using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class SurfaceOwnershipRepository : ISurfaceOwnershipRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public SurfaceOwnershipRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnerships()
        {
            return await _context.SurfaceOwnership.ToListAsync();
        }

        public async Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByLeaseId(string LeaseId)
        {
            return await _context.SurfaceOwnership.ToListAsync();
        }

        public async Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByTractId(string TractId)
        {
            return await _context.SurfaceOwnership.ToListAsync();
        }
    }
}
