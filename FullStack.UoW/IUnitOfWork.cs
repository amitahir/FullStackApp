using FullStack.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository studentRepository { get; }
        IEmployeeRepository employeeRepository { get; }

    }
}
