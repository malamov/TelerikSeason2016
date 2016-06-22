namespace HomeWork.Extensions
{
    using System;
    using HomeWork.Models;

    public static class Point3DExtensions
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            distance = Math.Sqrt(
                (firstPoint.x - secondPoint.x) * (firstPoint.x - secondPoint.x)+
                (firstPoint.y - secondPoint.y) * (firstPoint.y - secondPoint.y)+
                (firstPoint.z - secondPoint.z) * (firstPoint.z - secondPoint.z)
                );
            return distance;
        }

       
    }
}
