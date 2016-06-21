namespace HomeWork
{
    using System;
    using System.Linq;
    using Models;
    using Extensions;
    public class EuclideanSpace
    {
        static void Main(string[] args)
        {
            //Point3D point = new Point3D() { x = 1, y = 2, z = 3 };
            //Console.WriteLine(point);
            //Console.WriteLine(Point3D.PointO);
            //Console.WriteLine(Point3DExtensions.CalculateDistance(point, Point3D.PointO)); 

            var path = new Path();
            for (int i = 0; i < 10; i++)
            {
                path.AddPoinit(new Point3D(i, i * 2, i + 3));
            }


            PathStorage.SavePath(path, "../../path.txt");
            PathStorage.LoadPath("../../path.txt");


        }
    }
}
