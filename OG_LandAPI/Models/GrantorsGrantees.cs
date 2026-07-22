using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class GrantorsGrantees : IGrantorGranteeMainRepository
    {
        public int Id { get; set; }
        public string? GrantorId { get; set; }
        public string? GranteeId { get; set; }
        public decimal? GrossAcresMineralsMi { get; set; }
        public string? MineralInterestTextMi { get; set; }
        public decimal? MineralInterestMi { get; set; }
        public decimal? NetAcresMineralsMi { get; set; }
        public decimal? GrossAcresMineralsSi { get; set; }
        public string? SurfaceInterestTextSi { get; set; }
        public decimal? SurfaceInterestSi { get; set; }
        public decimal? NetAcresSurfaceSi { get; set; }
        public string? PaymentObligationText { get; set; }
        public string? PaymentObligation { get; set; }
        public string? BankId { get; set; }
        public long? BankAcctNo { get; set; }
        public decimal? BankFees { get; set; }
        public string? RoyaltyInterestText { get; set; }
        public decimal? Royalty { get; set; }
        public string? NetProfitsText { get; set; }
        public decimal? NetProfits { get; set; }
        public string? OrriText { get; set; }
        public decimal? Orri { get; set; }
        public string? SpecialText { get; set; }
        public decimal? Special { get; set; }
        public string? ExcessRoyaltyText { get; set; }
        public decimal? ExcessRoyalty { get; set; }
        public string? NpriText { get; set; }
        public decimal? Npri { get; set; }
        public string? WiText { get; set; }
        public decimal? Wi { get; set; }
        public string? DoiText { get; set; }
        public decimal? Doi { get; set; }
        public string? OtherText { get; set; }
        public decimal? Other { get; set; }
        public string? SubsidenceText { get; set; }
        public decimal? Subsidence { get; set; }

        public Task<object> GetAllGrantorsGrantees(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GrantorsGrantees>> RetrieveAllGrantorsGrantees(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllGrantorsGrantees(string name)
        {
            throw new NotImplementedException();
        }
    }
}
