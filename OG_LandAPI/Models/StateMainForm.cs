using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class StateMainForm
    {
        public int Id { get; set; }
        public string? StateId { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
    }
}
