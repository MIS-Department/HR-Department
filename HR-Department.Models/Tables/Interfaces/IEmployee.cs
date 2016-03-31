namespace HR_Department.Models.Tables.Interfaces
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string EmployeeNumber { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        byte[] ImageEmployee { get; set; }
    }
}
