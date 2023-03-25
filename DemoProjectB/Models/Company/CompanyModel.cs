using DemoProjectB.Models.Department;
using DemoProjectB.Models.Employee;

namespace DemoProjectB.Models.Company
{
    public class CompanyModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<EmployeeModel>? Employees { get; set; }
        public List<DepartmentModel>? Department { get; set; }
    }

}
