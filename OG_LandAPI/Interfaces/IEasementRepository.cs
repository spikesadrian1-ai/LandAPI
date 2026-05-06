using System.Threading.Tasks;

namespace OG_LandAPI.Intefaces
{
    internal interface IEasementRepository
    {        
        Task<object> GetAllEasements();
        Task<object> GetEasementByID(int id);
        Task<object> GetEasementByID();
    }
}