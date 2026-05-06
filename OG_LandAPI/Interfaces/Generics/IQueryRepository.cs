using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OG_LandAPI.Intefaces.Generics
{
    public interface IQueryRepository<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<ActionResult<IEnumerable<T>>> GetById(int Id);
        //Task<T> GetById(T T);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ActionResult<List<T>>> RetrieveAll();
        //Task<IEnumerable<T>> RetrieveAll(IList<T> T);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //Task<IEnumerable<T>> RetrieveAllByPageN();

    }
}
