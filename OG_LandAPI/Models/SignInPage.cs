using System;
using System.Collections.Generic;

namespace OG_LandAPI.Models
{
    public partial class SignInPage
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
