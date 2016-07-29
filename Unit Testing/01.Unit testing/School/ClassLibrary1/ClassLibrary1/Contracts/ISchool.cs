namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ISchool
    {
        string SchoolName { get; }

        ICollection<IStudent> StudentsInSchoolList { get; }

        ICollection<ICourse> CoursesList { get; }

        void AddStudent(IStudent student);

        void AddCourse(ICourse course);

    }
}