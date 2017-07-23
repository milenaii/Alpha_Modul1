using System;

namespace Classes2
{
    public struct Point3D
    {
        private static readonly Point3D startPoints = new Point3D(0,0,0);

        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }
        public int Z
        {
            get;
            set;
        }

        public Point3D(int x,int y,int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"Euclidian 3D coordinates of point: x = {this.X}, y = {this.Y}, z = {this.Z} ";
        }

    }
}
