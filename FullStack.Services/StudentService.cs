using FullStack.Database.Entities;
using FullStack.Interface.IServices;
using FullStack.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Services
{
    public partial class StudentService : BaseService, IStudentService
    {

        public StudentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<List<Student>> GetStudents()
        {
            var studentList = await _unitOfWork.studentRepository.GetAllStudents();
            return studentList.ToList();
        }
    }
}
