﻿namespace FridgeManager.ReportAzureFunction.Models
{
    internal class User
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }
    }
}
