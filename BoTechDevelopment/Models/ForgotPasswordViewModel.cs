﻿namespace BoTechDevelopment.Models
{
    public class ForgotPasswordViewModel
    {
        public string yourEmail { get; set; } = string.Empty;
        public bool SendOverEmail { get; set; } = true;
        public bool SendOverSMS { get; set; } = false;


    }
}
