using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class DropDownLists2
    {
        public int Id { get; set; }
        public string? OperatorId { get; set; }
        public string? LandmanId { get; set; }
        public string? TimberType { get; set; }
        public string? CarrierId { get; set; }
        public string? InsuranceType { get; set; }
        public string? Buyer { get; set; }
        public string? Seller { get; set; }
        public string? Gatherer { get; set; }
        public string? Treater { get; set; }
        public string? Processor { get; set; }
        public string? Compressor { get; set; }
        public string? ResponsibleParty { get; set; }
        public string? MainCompany { get; set; }
        public string? CurrentOperator { get; set; }
        public string? PreviousOperator { get; set; }
        public string? AcquiredFrom { get; set; }
        public string? SoldTo { get; set; }
    }
}
