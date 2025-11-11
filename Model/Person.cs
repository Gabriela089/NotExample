using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace School.Model
{
    public  class Person
    {
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
