using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Database.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public string PhoneNo { get; set; } = string.Empty;
    }
}
