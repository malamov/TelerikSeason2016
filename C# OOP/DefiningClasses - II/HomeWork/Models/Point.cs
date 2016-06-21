using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D PointO
        {
            get { return pointO; }
        }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.x, this.y, this.z);
        }

        public static Point3D Parse()
        {

        }

    }
}
