using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// test
namespace School.Model
{
   public  class CClas
    {
        public CClas(string name,Teacher teacher )
        {
            NameClass = name;
            Teacher = teacher;
            Students = new List<Student>();
        }

        
        public string NameClass { get; set; }
        public Teacher Teacher { get; set; }
        List<Student> Students { get; set; }
    }
}
