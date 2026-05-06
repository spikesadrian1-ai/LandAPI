using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class TractMainForm : ITractMainRepository
    {
        public int Id { get; set; }
        public string TractId { get; set; }
        public string OwnerId { get; set; }
        public string TaxId { get; set; }
        public string TractStatus { get; set; }
        public string TractType { get; set; }
        public string Active { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal? TotalAcreage { get; set; }
        public decimal? NetAcres { get; set; }
        public decimal? Developed { get; set; }
        public decimal? Undeveloped { get; set; }
        public decimal? Other { get; set; }
        public decimal? Outside { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string ProspectId { get; set; }
        public string DistrictId { get; set; }
        public string RegionId { get; set; }
        public string IncludeInGrandTotals { get; set; }
        public string IncludeInLeaseAcreageTotals { get; set; }
        public string IncludeInProspectAcreageTotals { get; set; }
        public string IncludeInDistrictAcreageTotals { get; set; }
        public string IncludeInPropertyAcreageTotals { get; set; }
        public string IncludeInStateCountyAcreageTotals { get; set; }
        public int? BeginningDepth { get; set; }
        public int? EndingDepth { get; set; }
        public string DepthNotes { get; set; }
        public string TractLeasedStatus { get; set; }
        public string DeedRef1 { get; set; }
        public string DeedRef2 { get; set; }
        public string DeedRef3 { get; set; }
        public string DeedRef4 { get; set; }
        public string PlatRef1 { get; set; }
        public string PlatRef2 { get; set; }
        public string PlatRef3 { get; set; }
        public string PlatRef4 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string FormationCode { get; set; }
        public string SpecialProvisionsNotes { get; set; }
        public string BasinId { get; set; }
        public string BaseLineId { get; set; }
        public string TobinId { get; set; }
        public string SeeAlsoTractId { get; set; }
        public string OkToPay { get; set; }
        public string TractNameShort { get; set; }
        public string TractNameMemo { get; set; }
        public string Notes { get; set; }
        public string AllDepths { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string TwnRngSecPk { get; set; }
        public string TractOwnerPk { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Task<object> GetTractsByID(string TractID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<List<TractMainForm>> RetrieveAllTracts()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<object> SearchAllTracts(string name)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tractMainForm"></param>
        /// <returns></returns>
        public Task<object> CreateNewTract(TractMainForm tractMainForm)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractID"></param>
        /// <returns></returns>
        public Task<object> UpdateTract(string TractID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<TractMainForm> ITractMainRepository.AddNewTract(TractMainForm tractMainForm)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractMainForm"></param>
        /// <returns></returns>
        public Task<TractMainForm> UpdateTract(TractMainForm tractMainForm)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tractMainForm"></param>
        /// <returns></returns>
        public Task<TractMainForm> DeleteTract(TractMainForm tractMainForm)
        {
            throw new NotImplementedException();
        }
    }
}
