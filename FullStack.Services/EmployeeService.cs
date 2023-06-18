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
    public partial class EmployeeService : BaseService, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<Employee>> GetEmployee()
        {
            var employeeList = await _unitOfWork.employeeRepository.GetAllEmployee();
            return employeeList.ToList();
        }
    }
}