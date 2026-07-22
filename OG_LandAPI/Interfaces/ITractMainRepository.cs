using OG_LandAPI.Models;

namespace OG_LandAPI.Interfaces
{
    public interface ITractMainRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<List<TractMainForm>> RetrieveAllTracts();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> GetTractsByID(string TractID);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllTracts(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractMainForm"></param>
        /// <returns></returns>
        public Task<TractMainForm> AddNewTract(TractMainForm tractMainForm);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractMainForm"></param>
        /// <returns></returns>
        public Task<TractMainForm> UpdateTract(TractMainForm tractMainForm);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractMainForm"></param>
        /// <returns></returns>
        public Task<TractMainForm> DeleteTract(TractMainForm tractMainForm);
    }
}

