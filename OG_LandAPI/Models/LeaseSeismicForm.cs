using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;

namespace OG_LandAPI.Models
{
    public partial class LeaseSeismicForm : ILeaseSeismicRepository
    {
        public int Id { get; set; }
        public int? SeismicPermitExpirationDays { get; set; }
        public DateTime? SeismicPermitExpirationDate { get; set; }
        public int? SeismicPermitExtensionDays { get; set; }
        public bool? WasTheSeismicPermitExtended { get; set; }
        public int? SeismicOptionExpirationDays { get; set; }
        public int? SeismicOptionExtensionDays { get; set; }
        public int? AcreOption { get; set; }
        public int AcreExtension { get; set; }
        public int AcrePrepaid { get; set; }
        public int AcreConvBonus { get; set; }
        public string OptionPeriod { get; set; }
        public DateTime OptionExpireDate { get; set; }
        public string SeismicOptionNotes { get; set; }
        public string TractId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid? TractOwnerPk { get; set; }

        public Task<IEnumerable<LeaseSeismicForm>> RetrieveAllLeaseSeismic()
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllLeaseSeismic(string name)
        {
            throw new NotImplementedException();
        }
    }
}
