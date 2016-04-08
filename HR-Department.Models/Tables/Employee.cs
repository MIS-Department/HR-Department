using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string SssNumber { get; set; }
        public string TinNumber { get; set; }
        public int CivilStatus { get; set; }
        public int TaxId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int PositionId { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateRegularization { get; set; }
        public int EmploymentStatusId { get; set; }
        public string PhilHealthNumber { get; set; }
        public string HdmfNumber { get; set; }
        public string HdmfRtn { get; set; }
        public string SalaryRate { get; set; }
        public string SalaryStructure { get; set; }
        public int SalaryTypeId { get; set; }
        public int IsResign { get; set; }
        public int IsActive { get; set; }
        public DateTime DateResign { get; set; }
        public int WorkersId { get; set; }
        public string InCaseOfEmergencyName { get; set; }
        public string InCaseOfEmergencyContactNo { get; set; }
        public byte[] ImageEmployee { get; set; }
        public int IsSelected { get; set; }

    }

    }

