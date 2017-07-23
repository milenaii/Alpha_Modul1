using System;
using System.Collections.Generic;

namespace Classes2
{
    public class Path
    {
        //List<Point3D> Points = new List<Point3D>();
        private List<Point3D> pathList;

        public Path()
        {
            this.pathList = new List<Point3D>();
        }

        public List<Point3D> PathList
        {
            get
            {
                return this.pathList;
            }
            private set
            {
                this.pathList = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.pathList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pathList.Remove(point);
        }

        public override string ToString()
        {
            foreach (Point3D point in pathList)
            {
                ToString();
            }
            return ToString();
        }
    }
}
