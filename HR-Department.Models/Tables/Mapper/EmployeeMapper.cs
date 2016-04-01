using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{


    public sealed class EmployeeMapper : ClassMapper<Employee>
    {
        public EmployeeMapper()
        {
            Table("employee");
            Map(m => m.EmployeeId).Column("employee_id").Key(KeyType.Identity);
            Map(m => m.EmployeeNumber).Column("employee_number");
            Map(m => m.LastName).Column("lastname");
            Map(m => m.FirstName).Column("firstname");
            Map(m => m.MiddleName).Column("middlename");
            //Map(m => m.Address).Column("address");
            //Map(m => m.Gender).Column("gender");
            //Map(m => m.ContactNumber).Column("contactno");
            //Map(m => m.Birthdate).Column("birthdate");
            //Map(m => m.SssNumber).Column("sss_number");
            //Map(m => m.TinNumber).Column("tin_number");
            //Map(m => m.CivilStatusId).Column("civil_status_id");
            //Map(m => m.TaxId).Column("tax_id");
            //Map(m => m.DepartmentId).Column("department_id");
            //Map(m => m.SectionId).Column("section_id");
            //Map(m => m.PositionId).Column("position_id");
            //Map(m => m.DateHired).Column("date_hired");
            //Map(m => m.DateRegularization).Column("date_regularization");
            //Map(m => m.EmploymentStatusId).Column("employment_status_id");
            //Map(m => m.PhilHealthNumber).Column("philhealth_number");
            //Map(m => m.HdmfNumber).Column("hdmf_number");
            //Map(m => m.HdmfRtn).Column("hdmf_rtn");
            //Map(m => m.SalaryRate).Column("salary_rate");
            //Map(m => m.SalaryStructure).Column("salary_structure");
            //Map(m => m.SalaryTypeId).Column("salary_type_id");
            //Map(m => m.IsResign).Column("is_resigned");
            //Map(m => m.IsActive).Column("is_active");
            //Map(m => m.DateResign).Column("date_resigned");
            //Map(m => m.WorkersId).Column("workers_id");
            //Map(m => m.InCaseOfEmergencyName).Column("in_case_of_emergency_name");
            //Map(m => m.InCaseOfEmergencyContactNo).Column("in_case_of_emergency_contact_number");
            Map(m => m.ImageEmployee).Column("image_employee");
            //Map(m => m.IsSelected).Column("is_selected");
        }
    }
}
