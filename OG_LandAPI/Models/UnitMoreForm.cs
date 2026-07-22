using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class UnitMoreForm
    {
        public int Id { get; set; }
        public DateTime? AcquiredDate { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? DateOnLine { get; set; }
        public DateTime? ShutInDate { get; set; }
        public DateTime? DateSold { get; set; }
        public DateTime? PluggedDate { get; set; }
        public DateTime? OtherDate1 { get; set; }
        public DateTime? OtherDate2 { get; set; }
        public DateTime? PayoutDate1 { get; set; }
        public DateTime? PayoutDate2 { get; set; }
        public DateTime? PayoutDate3 { get; set; }
        public DateTime? PayoutDate4 { get; set; }
        public string? RecordingInformation { get; set; }
    }
}
