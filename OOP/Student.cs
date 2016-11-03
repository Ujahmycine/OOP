using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        //Properties of this class
        public Name StudentName { get; set; }
        public Department StudentDepartment { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MatricNumber { get; set; }
        public string JambNumber { get; set; }
        public string StudentType { get; set; }
        public string CourseData { get; set; }
        public	string SchoolData {get; set;}

        //Constructor
        public Student(Name studentName, Department studentDepartment)
        {
            StudentName = studentName;
            StudentDepartment = studentDepartment;
        }
    }

    public class Name
    {
        //Properties
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othername { get; set; }
        public string Fullname { get; set; }
        public string Initials { get; set; }

        //Constructor
        public Name(string sname, string fname, string oname ="")
        {
            Surname = sname.ToUpper();
            Firstname = fname.ToUpper();
            Othername = oname.ToUpper();
            Fullname = Surname + " " + Firstname + " " + Othername;
            if (string.IsNullOrEmpty(oname))
            {
                Initials = Surname.Substring(0,1) + "." + Firstname.Substring(0,1) ;

            }
            else
            {
                Initials = Surname.Substring(0, 1) + "." + Firstname.Substring(0, 1) + "." + Othername.Substring(0,1);

            }
            
        }
    }

    public class Department
    {
        //properties
        public string Name { get; set; }
        public string Faculty { get; set; }

        //Constructor
        public Department(string name)
        {
            Name = name;
        }
    }

}
