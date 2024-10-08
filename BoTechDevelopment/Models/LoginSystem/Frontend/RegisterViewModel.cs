﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BoTechDevelopment.Models.LoginSystem.Frontend
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
        public char HouseIndex { get; set; } = 'a';
        public int PLZ { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
