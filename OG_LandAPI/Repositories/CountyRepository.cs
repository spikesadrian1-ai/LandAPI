using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Repositories
{
    public class CountyRepository : ICountyRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public CountyRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CountyMasterMainForm>> RetrieveAllCounties() {

            return await _context.CountyMasterMainForm.ToListAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CountyMasterMainForm>> GetCountiesByID(string countyId)
        {
            return await _context.CountyMasterMainForm.ToListAsync();

            ///// TO RETRIEVE DATA FROM MULTIPLE TABLES
            //return await _context.CountyMasterMainForm
            //    .Include(e => e.tableName)
            //    .ThenInclude(e => e.tableName)  //  REPEAT IF NEEDED
            //    .FirstOrDefaultAsync(e => e.countyId == countyId);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<object> AddNewCounty(CountyMasterMainForm countyMasterMainForm) {
            var result = await _context.CountyMasterMainForm.AddAsync(countyMasterMainForm);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //public async Task<object> DeleteCounty(string countyID)
        public async void DeleteCounty(string countyID) {
            var result = await _context.CountyMasterMainForm
               .FirstOrDefaultAsync(e => e.CountyId == countyID);
            if (result != null)  {
                _context.CountyMasterMainForm.Remove(result);
                await _context.SaveChangesAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //public async Task<object> UpdateCounty(int Id, string CountyID) {
        public async Task<object> UpdateCounty(CountyMasterMainForm county) {

            var result = await _context.CountyMasterMainForm
                .FirstOrDefaultAsync(e => e.Id == county.Id && e.CountyId == county.CountyId);

            if (result != null) {

                result.CountyId = county.CountyId;
                result.Id = county.Id ;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        public async Task<object> DeleteCounty(CountyMasterMainForm county) {
            var result = await _context.CountyMasterMainForm
                .FirstOrDefaultAsync(e => e.CountyId == county.CountyId);
            if (result != null) {

                //result.Id = county.Id;
                result.CountyId = county.CountyId;
                result.CountyName = county.CountyName;
                result.StateId = county.StateId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        
        async Task<object> ICountyRepository.GetCountiesByID(string CountyID)
        {
            return await _context.CountyMasterMainForm.ToListAsync();

            ///// TO RETRIEVE DATA FROM MULTIPLE TABLES
            //return await _context.CountyMasterMainForm
            //    .Include(e => e.tableName)
            //    .ThenInclude(e => e.tableName)  //  REPEAT IF NEEDED
            //    .FirstOrDefaultAsync(e => e.countyId == countyId);
        }

        
        public Task<object> SearchAllCounties(string name)
        {
            throw new NotImplementedException();
        }

        
        async Task<CountyMasterMainForm> ICountyRepository.AddNewCounty(CountyMasterMainForm countyMasterMainForm)
        {
            var result = await _context.CountyMasterMainForm.AddAsync(countyMasterMainForm);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        
        async Task<CountyMasterMainForm> ICountyRepository.UpdateCounty(CountyMasterMainForm countyMasterMainForm)
        {
            var result = await _context.CountyMasterMainForm
         .FirstOrDefaultAsync(e => e.Id == countyMasterMainForm.Id && e.CountyId == countyMasterMainForm.CountyId);

            if (result != null)
            {
                result.Id = countyMasterMainForm.Id;
                result.CountyId = countyMasterMainForm.CountyId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        
        async Task<CountyMasterMainForm> ICountyRepository.DeleteCounty(CountyMasterMainForm countyMasterMainForm)
        {
            var result = await _context.CountyMasterMainForm
          .FirstOrDefaultAsync(e => e.CountyId == countyMasterMainForm.CountyId);
            if (result != null)
            {

                //result.Id = county.Id;
                result.CountyId = countyMasterMainForm.CountyId;
                result.CountyName = countyMasterMainForm.CountyName;
                result.StateId = countyMasterMainForm.StateId;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
