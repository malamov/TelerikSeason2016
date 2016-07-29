namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School.Contracts;
    using School.Models;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithInvalidNumber_ShouldThrow()
        {
            var student = new Student("name", 999999999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentsNameThrowsExceptionIfEmpty()
        {
            var student = new Student("", 10001);
        }
    }
}
