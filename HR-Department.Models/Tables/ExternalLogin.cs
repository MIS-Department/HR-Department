using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class ExternalLogin : IExternalLogin
    {
        public Guid ExternalLoginId { get; set; }
        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Provider { get; set; }
    }
}
