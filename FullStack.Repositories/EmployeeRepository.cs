using FullStack.Database.DataContext;
using FullStack.Database.Entities;
using FullStack.Interface.IRepository;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Repositories
{
    public partial class EmployeeRepository : IEmployeeRepository
    {
        protected ApplicationDbContext Context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return await Context.Employees.ToListAsync();
        }
       
    }
}
