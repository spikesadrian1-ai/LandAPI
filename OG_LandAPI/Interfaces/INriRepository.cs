using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface INriRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<Nri>> RetrieveAllNRInterest(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> GetNRInterest(int ID/*, string tractid*/);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllNRInterest(string name/*, string tractid*/);

    }
}
