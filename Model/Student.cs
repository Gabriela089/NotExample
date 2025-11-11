using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
   public class Student:Person
    {
        public Student( string name, int age):base(name,age)
        {
            //Grades = grades;
            //AverageGrades = 0;
        }

       public List<int> Grades { get; set; }
       // public double AverageGrades { get; set; }


    }
}
