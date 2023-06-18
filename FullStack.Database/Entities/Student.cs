using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Database.Entities
{
    public class Student
    {
        public Guid id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public long phone
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }

    }
}
