using DemoProjectB.Models.Company;

namespace DemoProjectB.Models
{
    public class UserModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public CompanyModel? Company { get; set; }
    }
}
