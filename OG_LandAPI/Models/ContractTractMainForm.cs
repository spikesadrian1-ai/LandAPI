using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class ContractTractMainForm
    {
        public int Id { get; set; }
        public string? ContractId { get; set; }
        public string? ContractType { get; set; }
        public string? SubType { get; set; }
        public string? ContractStatus { get; set; }
        public decimal? Consideration { get; set; }
        public string? ContractDescription { get; set; }
        public string? TractId { get; set; }
        public string? LeaseId { get; set; }
        public string? FormationType { get; set; }
    }
}
