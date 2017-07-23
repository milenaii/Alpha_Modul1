using System;
using System.Collections.Generic;

namespace Classes2
{
    public class Start
    {
        static void Main()
        {
            Point3D pointOne = new Point3D(3, 5, 8);
            Point3D pointTwo = new Point3D(1, 4, 2);
            Point3D pointThree = new Point3D(6, 8, 5);
            Point3D pointFour = new Point3D(3, 7, 2);
           // Point3D pointO = new Point3D.o;

            //Console.WriteLine(pointOne);

            Path path = new Path();
            path.AddPoint(pointOne);
            path.AddPoint(pointTwo);
            path.AddPoint(pointThree);
            path.AddPoint(pointTwo);
            path.PathList.ForEach(x => Console.WriteLine(x));

            //string fileName = @"../../FilePath.txt";
            //PathStorage.SavePathInFile(fileName,path);

            //List<string> elements = new List<string>();


        }
    }
}
