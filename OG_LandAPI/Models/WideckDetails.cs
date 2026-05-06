using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class WideckDetails
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string InterestFormula { get; set; }
        public DateTime? Effective { get; set; }
        public DateTime? Expire { get; set; }
        public string Suspense { get; set; }
        public string InterestType { get; set; }
        public string SendReports { get; set; }
        public string Active { get; set; }
        public string TractId { get; set; }
        public string LeaseId { get; set; }
        public string WellId { get; set; }
    }
}
