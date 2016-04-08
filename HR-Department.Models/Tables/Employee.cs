using System;
using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class Employee
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
        public byte ImageEmployee { get; set; }
        public int IsSelected { get; set; }

    }

    public sealed class EmployeeMapper : ClassMapper<Employee>
    {
        public EmployeeMapper ()
        {
            Table("employee");
            Map(m => m.EmployeeId).Column("employee_id").Key(KeyType.Identity);
            Map(m => m.EmployeeNumber).Column("employee_number");
            Map(m => m.LastName).Column("lastname");
            Map(m => m.FirstName).Column("firstname");
            Map(m => m.MiddleName).Column("middlename");
            Map(m => m.Address).Column("address");
            Map(m => m.Gender).Column("gender");
            Map(m => m.ContactNumber).Column("contactno");
            Map(m => m.Birthdate).Column("birthdate");
            Map(m => m.SssNumber).Column("sss_number");
            Map(m => m.TinNumber).Column("tin_number");
            Map(m => m.CivilStatus).Column("civil_status");
            Map(m => m.TaxId).Column("tax_id");
            Map(m => m.DepartmentId).Column("department_id");
            Map(m => m.SectionId).Column("section_id");
            Map(m => m.PositionId).Column("position_id");
            Map(m => m.DateHired).Column("date_hired");
            Map(m => m.DateRegularization).Column("date_regularization");
            Map(m => m.EmploymentStatusId).Column("employment_status_id");
            Map(m => m.PhilHealthNumber).Column("philhealth_number");
            Map(m => m.HdmfNumber).Column("hrdm_number");
            Map(m => m.HdmfRtn).Column("hdmf_rtn");
            Map(m => m.SalaryRate).Column("salary_rate");
            Map(m => m.SalaryStructure).Column("salary_structure");
            Map(m => m.SalaryTypeId).Column("salary_type_id");
            Map(m => m.IsResign).Column("is_resigned");
            Map(m => m.IsActive).Column("is_active");
            Map(m => m.DateResign).Column("date_resigned");
            Map(m => m.WorkersId).Column("workers_id");
            Map(m => m.InCaseOfEmergencyName).Column("in_case_of_emergency_name");
            Map(m => m.InCaseOfEmergencyContactNo).Column("in_case_of_emergency_number");
            Map(m => m.ImageEmployee).Column("image_employee");
            Map(m => m.IsSelected).Column("is_selected");
        }
    }
}
