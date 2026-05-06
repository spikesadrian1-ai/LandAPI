using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Models;


namespace OG_LandAPI.Intefaces
{
    public interface IStateMainRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<StateMainForm>> RetrieveAllStates(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllStates(string name/*, string tractid*/);


        /// <summary>
        /// 
        /// </summary>
        Task<object> CreateNewState();

    }

}
