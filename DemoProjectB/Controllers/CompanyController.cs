using DemoProjectB.Models.Company;
using DemoProjectB.Models.Employee;
using DemoProjectB.Models.Department;
using Microsoft.AspNetCore.Mvc;

namespace DemoProjectB.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            var returnModel = new CompanyModel()
            {
                Name = "Comitas AG",
                Address = "Musine Kokalari 10",
                Employees = new List<EmployeeModel>()
                {
                    new EmployeeModel()
                    {
                        FirstName = "Adriatik",
                        LastName = "Ademi",
                        Position = "Head of dev",
                        Salary = 100
                    },
                    new EmployeeModel()
                    {
                        FirstName = "Emerjon",
                        LastName = "Hasani",
                        Position = "Senior dev",
                        Salary = 300000
                    },
                },

                Department = new List<DepartmentModel>
                {
                    new DepartmentModel()
                    {
                        Name="DepartmentA",
                        HeadOfDepartment="B"
                    },
                    new DepartmentModel()
                    {
                        Name="DepartmentA",
                        HeadOfDepartment="B"
                    },
                    new DepartmentModel()
                    {
                        Name="DepartmentA",
                        HeadOfDepartment="B"
                    }
                }
            };
            return View(returnModel);
        }
    }
}
