using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format($"{X},{Y},{Z}");
        }



    }
    internal class _04_01
    {
        static void Main2(string[] args)
        {
            Point3D p1;
            p1.X = 10;
            p1.Y = 10;
            p1.Z = 10;

            Console.WriteLine(p1.ToString());

            Point3D p2 = new Point3D(100, 200, 300);
            Console.WriteLine(p2.ToString());
        }
    }
}
