using FullStack.Database.DataContext;
using FullStack.Database.Entities;
using FullStack.Interface.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Repositories
{
    public partial class StudentRepository : IStudentRepository
    {
        protected ApplicationDbContext Context;
        
        public StudentRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await Context.Students.ToListAsync();
        }
    }
}
