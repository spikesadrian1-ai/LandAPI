using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;

namespace OG_LandAPI.Intefaces
{
    public interface IDefaultBankMasterRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<DefaultBankMasters>> RetrieveAllDefaultBanks(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> GetAllDefaultBanks(int ID/*, string tractid*/);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllDefaultBanks(string name/*, string tractid*/);

    }
}
