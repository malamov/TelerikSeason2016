namespace Attributes
{
    using System;


    [Version(10,1)]
    class Program
    {
        [AttributeUsage(AttributeTargets.Struct |
         AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
        public class VersionAttribute : System.Attribute
        {
            public int Major { get; private set; }

            public int Minor { get; private set; }


            public VersionAttribute(int major, int minor)
            {
                this.Major = major;
                this.Minor = minor;
            }
        }


    }
}
