﻿using Microsoft.AspNetCore.Identity;

namespace Rungroupwebapp.Models
{
    public class AppUser
    {
        public int Pace { get; set; }
        public int? Mileage { get; set; }

        public Address? Address { get; set; }



    }
}
