using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface IWIDeckInterestRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<WideckInterest>> RetrieveAllWideckInterests(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllWideckInterests(string name/*, string tractid*/);

    }
}
