using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;


namespace OG_LandAPI.Intefaces
{
    public interface IRegionMasterRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<RegionMasterMainForm>> RetrieveAllRegions();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> SearchAllRegions(string name/*, string tractid*/);

    }
}
