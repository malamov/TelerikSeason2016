using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using School.Contracts;

namespace School.Models
{
   public class School : ISchool
    {
        private string schoolName;

        public School(string initSchoolName)
        {
            this.SchoolName = initSchoolName;
            this.CoursesList = new List<ICourse>();
            this.StudentsInSchoolList = new List<IStudent>();
        }

        public ICollection<ICourse> CoursesList { get; set; }

        public ICollection<IStudent> StudentsInSchoolList { get; set; }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name cannot be empty!");
                }
                this.schoolName = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.CoursesList.Add(course);
        }

        public void AddStudent(IStudent student)
        {
            foreach (var stud in StudentsInSchoolList)
            {
                if (stud.StudentNumber == student.StudentNumber)
                {
                    throw new ArgumentException("Student's numbers canonot duplicate !");
                }
            }
            this.StudentsInSchoolList.Add(student);
        }

    }
}
