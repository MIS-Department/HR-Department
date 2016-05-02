using System;

namespace HR_Department.Models.Tables.Interfaces
{
    public interface IExternalLogin
    {
        Guid ExternalLoginId { get; set; }
        Guid UserId { get; set; }
        string LoginProvider { get; set; }
        string Provider { get; set; }
    }
}
