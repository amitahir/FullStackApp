using FullStack.Database.Entities;
using FullStack.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<List<Student>> GetStudents()
        {
            var result = (await _studentService.GetStudents());
            return result;
        }



    }
}
