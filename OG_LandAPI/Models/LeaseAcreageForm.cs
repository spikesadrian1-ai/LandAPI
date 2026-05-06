using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class LeaseAcreageForm : ILeaseAcreageRepository
    {
        public int Id { get; set; }
        public string MineralOwnership { get; set; }
        public decimal MineralOwnershipDecimal { get; set; }
        public string SurfaceOwnership { get; set; }
        public decimal SurfaceOwnershipDecimal { get; set; }
        public decimal TotalAcreage { get; set; }
        public decimal Developed { get; set; }
        public decimal Undeveloped { get; set; }
        public decimal OtherAcreage { get; set; }
        public decimal OutsideAcreage { get; set; }
        public decimal HbpAcres { get; set; }
        public decimal TotalSurface { get; set; }
        public decimal SurfacedDeveloped { get; set; }
        public string AcreageNotes { get; set; }
        public string TractId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid? TractOwnerPk { get; set; }

        public Task<object> GetLeaseAcreagesByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeaseAcreageForm>> RetrieveAllLeaseAcreages()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllLeaseAcreages(string name)
        {
            throw new NotImplementedException();
        }
    }
}
