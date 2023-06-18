using FullStack.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Interface.IRepository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployee();
    }
}
