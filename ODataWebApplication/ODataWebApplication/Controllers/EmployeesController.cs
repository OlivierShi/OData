using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData;
using ODataWebApplication.Extensions;
using ODataWebApplication.Services;

namespace ODataWebApplication.Controllers
{
    public class EmployeesController : ODataController
    {
        private IEmployeeRepository repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        [EnableQuery(PageSize = PaginationEnableQueryAttribute.DefaultMaxPageSize)]
        public IActionResult Get()
        {
            return Ok(this.repository.Employees);
        }
    }
}
