using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class TractLeaseConnectionRepository : ITractLeaseConnectionRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractLeaseConnectionRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TractsLeaseConnection>> RetrieveAllTractsLease()
        {
            //throw new NotImplementedException();
            return await _context.TractsLeaseConnection.ToListAsync();
        }

        public async Task<IEnumerable<TractsLeaseConnection>> SearchAllTractsLeaseConnectionsByTractId(string TractId)
        {
            //throw new NotImplementedException();
            return await _context.TractsLeaseConnection.ToListAsync();
        }

        public async Task<TractsLeaseConnection> AddNewTractsLeaseConnections(string TractId)
        {
            throw new NotImplementedException();

            //var result = await _context.TractsLeaseConnection.AddAsync(TractsLeaseConnection);
            //await _context.SaveChangesAsync();
            //return result.Entity;
        }

        public async Task<TractsLeaseConnection> DeleteTractsLeaseConnections(int Id)
        {
            throw new NotImplementedException();

            //var result = await _context.TractsLeaseConnection
            //.FirstOrDefaultAsync(e => e.Id == Id);
            //if (result != null)
            //{

            //    //result.Id = county.Id;
            //    result.Id = Id;
            //    result.CountyName = countyMasterMainForm.CountyName;
            //    result.StateId = countyMasterMainForm.StateId;

            //    await _context.SaveChangesAsync();

            //    return result;
            //}

            //return null;
        }

        //public async Task<TractsLeaseConnection> GetTractsLeaseConnectionsByTractID(string TractId)
        //{
        //    throw new NotImplementedException();

        //    //return await _context.TractsLeaseConnection.ToListAsync();

        //    ///// TO RETRIEVE DATA FROM MULTIPLE TABLES
        //    //return await _context.TractsLeaseConnection
        //    //    .Include(e => e.tableName)
        //    //    //.ThenInclude(e => e.tableName)  //  REPEAT IF NEEDED
        //    //    .FirstOrDefaultAsync(e => e.tractId == TractId);
        //}

    }
}
