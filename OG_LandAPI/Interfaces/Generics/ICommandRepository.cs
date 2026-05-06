using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OG_LandAPI.Intefaces.Generics
{
    public interface ICommandRepository<T>
    {       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<T> Create(T T);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<T> Update(T T);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<T> Delete(T T);


    }
}
