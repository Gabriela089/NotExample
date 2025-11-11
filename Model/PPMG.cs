using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
   public class PPMG
    {
        public PPMG()
        {
            teachers = new List<Teacher>();
            CClass = new List<CClas>();
        }

        public List<Teacher> teachers { get; set; }
        public List<CClas> CClass { get; set; }
    }
}
