using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Organization { get; set; }
        public string? EmailAddress { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int Telephone { get; set; }
    }
}
