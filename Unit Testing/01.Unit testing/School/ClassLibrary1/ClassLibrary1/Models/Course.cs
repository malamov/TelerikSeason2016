using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using School.Contracts;

namespace School.Models
{
   public class Course : ICourse
    {
        public ICollection<IStudent> studentsList;
        private string courseName;

        public Course(string initCourseName)
        {
            this.CourseName = initCourseName;
            this.studentsList = new List<IStudent>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be empty!");
                }
                this.courseName = value;
            }
        }


        public void AddStudent(IStudent student)
        {
            if (this.studentsList.Count > 30)
            {
                throw new ArgumentException("Students at a course cannot be more than 30!");
            }
            else
            {
                this.studentsList.Add(student); 
            }
        }

        public void RemoveStudent(IStudent student)
        {
            if (studentsList.Count < 1)
            {
                throw new ArgumentException("This course is already empty");
            }
            this.studentsList.Remove(student);
        }
    }
}
