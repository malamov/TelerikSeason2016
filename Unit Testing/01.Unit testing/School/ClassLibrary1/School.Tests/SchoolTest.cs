namespace School.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School.Models;
    using School.Contracts;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructor_ShouldMakeInstanceOf_CollectionOfCourses()
        {
            var school = new School("name");

            Assert.IsInstanceOfType(school.CoursesList, typeof(List<ICourse>));
        }

        [TestMethod]
        public void SchoolConstructor_ShouldMakeInstanceOf_CollectionOfStudents()
        {
            var school = new School("name");

            Assert.IsInstanceOfType(school.StudentsInSchoolList, typeof(List<IStudent>));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_WithNameNull_ShouldThrowAnException()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void School_WithNameStringEmpty_ShoulThrowAnException()
        {
            var school = new School("");
        }

        [TestMethod]
        public void School_ShouldProperlySetName()
        {
            var expected = "EG Best School ever";

            var school = new School(expected);

            Assert.AreEqual(expected, school.SchoolName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddingStudentsWithSameNumberShouldThrow()
        {
            var school = new School("PMG Vasil Levski");
            var student1 = new Student("Ceko Cekov", 10001);
            var student2 = new Student("Boiko Borisov", 10001);

            school.AddStudent(student1);
            school.AddStudent(student2);

        }
    }
}
