using FullStack.Database.DataContext;
using FullStack.Interface.IRepository;
using FullStack.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.UoW
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext Context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.Context = context;
            studentRepository = new StudentRepository(Context);
            employeeRepository = new EmployeeRepository(Context);
        }

        private bool disposed;

        public IStudentRepository studentRepository { get; }
        public IEmployeeRepository employeeRepository { get; }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
