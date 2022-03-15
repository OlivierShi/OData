using ODataWebApplication.Models;

namespace ODataWebApplication.Services
{
    public class EmployeeInMemRepository : IEmployeeRepository
    {
        private readonly IList<Employee> employees;

        public EmployeeInMemRepository()
        {
            this.employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Jay", JobTitle = JobTitle.Partner, Location = new Address() { City = "Beij", Street = "Haid" } },
                new Employee() { Id = 2, Name = "Xia", JobTitle = JobTitle.PM, Location = new Address() { City = "Beij", Street = "Chaoy" } },
                new Employee() { Id = 3, Name = "Yo", JobTitle = JobTitle.SDE, Location = new Address() { City = "Nanj", Street = "Jinl" } },
                new Employee() { Id = 4, Name = "Jin", JobTitle = JobTitle.SDE, Location = new Address() { City = "Nanj", Street = "Qinh" } },
                new Employee() { Id = 5, Name = "Hua", JobTitle = JobTitle.SDE, Location = new Address() { City = "Hen", Street = "Hez" } },
                new Employee() { Id = 6, Name = "Yi", JobTitle = JobTitle.Designer, Location = new Address() { City = "Suz", Street = "Taih" } },
                new Employee() { Id = 7, Name = "Qin", JobTitle = JobTitle.Tester, Location = new Address() { City = "Shan", Street = "Hand" } }
            };
        }

        IEnumerable<Employee> IEmployeeRepository.Employees => this.employees;
    }
}
