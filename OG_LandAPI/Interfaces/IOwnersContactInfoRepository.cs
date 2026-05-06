using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OG_LandAPI.Intefaces
{
    public interface IOwnersContactInfoRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<IOwnersContactInfoRepository>> RetrieveOwnersContactInfo();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchOwnersContactInfo(string name/*, string tractid*/);

    }
}
