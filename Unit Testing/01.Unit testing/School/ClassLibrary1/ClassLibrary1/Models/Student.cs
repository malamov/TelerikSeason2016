using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using School.Contracts;

namespace School.Models
{
    
   public class Student : IStudent
    {
        private const int minStudentNumber = 10000;
        private const int maxsStudentsNumber = 99999;

        private string name;
        private int studentNumber;

        public Student(string name, int studNumber)
        {
            this.Name = name;
            this.StudentNumber = studNumber;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Student's name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
           
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value > maxsStudentsNumber || value < minStudentNumber)
                {
                    throw new ArgumentException("Invalid Student number");
                }
                else
                {
                    this.studentNumber = value;
                }
            } 
        }


    }
}
