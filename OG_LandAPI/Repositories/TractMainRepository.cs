using Microsoft.EntityFrameworkCore;
using OG_LandAPI.Interfaces;
using OG_LandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OG_LandAPI.Repositories
{
    public class TractMainRepository : ITractMainRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractMainRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<TractMainForm>> RetrieveAllTracts()
        {
            return await _context.TractMainForm.ToListAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TractMainForm>> GetTractsByID(string tractID)
        {
            return await _context.TractMainForm.ToListAsync();

            ///// TO RETRIEVE DATA FROM MULTIPLE TABLES
            //return await _context.CountyMasterMainForm
            //    .Include(e => e.tableName)
            //    .ThenInclude(e => e.tableName)  //  REPEAT IF NEEDED
            //    .FirstOrDefaultAsync(e => e.countyId == countyId);
        }


        Task<object> ITractMainRepository.GetTractsByID(string TractID)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllTracts(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<TractMainForm> AddNewTract(TractMainForm tractMainForm)
        {
            var result = await _context.TractMainForm.AddAsync(tractMainForm);
            await _context.SaveChangesAsync();
            return result.Entity;

            ////  OR

            // if (_context.TractMainForm.Any(x => x.propertyName.Equals(TractMainForm.TractId, StringComparison.OrdinalIgnoreCase))) return;

            //this._context.TractMainForm.Add(tractMainForm);
            //await this._context.SaveChangesAsync();
        }

        public async Task<TractMainForm> UpdateTract(TractMainForm tractMainForm)
        {
            var result = await _context.TractMainForm
                .FirstOrDefaultAsync(e => e.TractId == tractMainForm.TractId);

            if (result != null)
            {
                //result.Id = county.Id;
                result.TractId = tractMainForm.TractId;
                //result.TractNameShort = tractMainForm.TractNameShort;
                //result.StateId = tractMainForm.StateId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public Task<TractMainForm> DeleteTract(TractMainForm tractMainForm)
        {
            throw new NotImplementedException();
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="county"></param>
        ///// <returns></returns>
        //public async Task<object> DeleteTract(TractMainForm tractMainForm)
        //{
        //    var result = await _context.TractMainForm
        //        .FirstOrDefaultAsync(e => e.TractId == tractMainForm.TractId);

        //    if (result != null)
        //    {
        //        //result.Id = county.Id;
        //        result.TractId = tractMainForm.CountyId;

        //        await _context.SaveChangesAsync();

        //        return result;
        //    }

        //    return null;
        //}

    }
}

