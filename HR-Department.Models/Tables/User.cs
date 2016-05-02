using System;
using Microsoft.AspNet.Identity;

namespace HR_Department.Models.Tables
{
    public class User : IUser
    {
        public Guid UserId { get; set; }   
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public int UserRight { get; set; }

        string IUser<string>.Id => UserId.ToString();
    }
}
