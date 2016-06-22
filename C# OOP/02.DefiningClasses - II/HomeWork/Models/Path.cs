
namespace HomeWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path 
    {
        private ICollection<Point3D> points;

        public Path()
        {
            this.points = new HashSet<Point3D>();
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
    }
}
