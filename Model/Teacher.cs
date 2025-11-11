using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Teacher:Person
    {
        public Teacher(string name, int age,string subject ) : base(name, age)
        {
            Subject = subject;
           
        }

        public string Subject { get; set; }
    }
}
