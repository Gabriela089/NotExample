using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Controllers
{
   public class PPMG_Controller
    {
        public PPMG_Controller()
        {
            PpMG = new PPMG();
        }

        public PPMG PpMG { get; set; }
        public string AddTeacher(string name, int age, string subject)
        {
            Teacher newteacher = new Teacher(name, age, subject);
            PpMG.teachers.Add(newteacher);
            return "Add Teacher";
        }
        public string AddCClass(string nameClass,Teacher teacher)
        {
            CClas newClass = new CClas(nameClass, teacher);
            return "Add Class";
        }
        public string AddStudent(string name, int age)
        {
            Student newStudent = new Student(name, age);
          
            return "Add Student";
        }
    }
}
