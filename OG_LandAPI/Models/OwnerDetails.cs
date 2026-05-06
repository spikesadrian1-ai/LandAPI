using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class OwnerDetails
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string FullName { get; set; }
    }
}
