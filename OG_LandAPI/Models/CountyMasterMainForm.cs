using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class CountyMasterMainForm : ICountyRepository
    {      
        public int Id { get; set; }
        public string? StateId { get; set; }
        public string? CountyId { get; set; }
        public string? CountyName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<object> GetCountiesByID(string? CountyID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CountyMasterMainForm>> RetrieveAllCounties()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> SearchAllCounties(string? name)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="county"></param>
        /// <returns></returns>
        //public Task<object> AddNewCounty(CountyMasterMainForm county)
        //{
        //    throw new NotImplementedException();
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        public Task<object> CreateNewCounty(CountyMasterMainForm county)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<object> DeleteCounty(int ID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyID"></param>
        /// <returns></returns>
        public Task<object> UpdateCounty(int Id, string? CountyID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        public Task<CountyMasterMainForm> AddNewCounty(CountyMasterMainForm countyMasterMainForm)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        public Task<CountyMasterMainForm> UpdateCounty(CountyMasterMainForm countyMasterMainForm)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        public Task<CountyMasterMainForm> DeleteCounty(CountyMasterMainForm countyMasterMainForm)
        {
            throw new NotImplementedException();
        }
    }
}
