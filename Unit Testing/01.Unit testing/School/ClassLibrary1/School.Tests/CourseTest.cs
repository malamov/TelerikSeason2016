namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School.Contracts;
    using School.Models;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseCreate_WithNullName_ShouldThrowAnException()
        {
            var course = new Course(null); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseCreate_WithEmptyName_SholdThrowArgumentException()
        {
            Course course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddingStudentsToCourse_WithMoreThan30Students_ShouldThrow()
        {         
            Course course = new Course("Maths");
          
            int maxCourseCapacity = 30;
            for (int i = 0; i <= maxCourseCapacity + 1; i++)
            {
                course.AddStudent(new Student("student",10001));
            }
        }


        [TestMethod]
        public void CourseConstructor_ShouldInstanceCollectionOfStudents()
        {
            var course = new Course("name");

            Assert.IsInstanceOfType(course.studentsList, typeof(ICollection<IStudent>));
        }
    }
}