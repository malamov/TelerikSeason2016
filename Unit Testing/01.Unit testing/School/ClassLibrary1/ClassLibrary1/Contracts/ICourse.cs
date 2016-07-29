namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string CourseName { get; }

        void AddStudent(IStudent student);
        void RemoveStudent(IStudent student);
    }
}