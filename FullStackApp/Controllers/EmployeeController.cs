using FullStack.Database.Entities;
using FullStack.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet]
        [Route("GetEmployee")]
        public async Task<List<Employee>> GetEmployee()
        {
            var result = (await _employeeService.GetEmployee());
            return result;
        }
    }
}
