using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class UnitInterestsForm
    {
        public int Id { get; set; }
        public string InterestDescription { get; set; }
        public string ResponsibleParty { get; set; }
        public string CurrentOperator { get; set; }
        public string PreviousOperator { get; set; }
        public string AcquiredFrom { get; set; }
        public string SoldTo { get; set; }
    }
}
