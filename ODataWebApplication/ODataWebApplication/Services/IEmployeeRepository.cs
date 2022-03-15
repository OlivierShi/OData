using ODataWebApplication.Models;

namespace ODataWebApplication.Services
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> Employees { get; }
    }
}
