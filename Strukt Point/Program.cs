using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukt_Point
{
    public struct Point
    {
        private int x;
        private int y;
        private int z;

        public Point(int xPos, int yPos, int zPos)
        {
            x = xPos;
            y = yPos;
            z = zPos;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
        public static Point Add(Point p1, Point p2)
        {
            return p1 + p2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2,2,2);
            Point p2 = new Point(4,4,4);

            Console.WriteLine("Point.Add(p1,p2) = {0}", Point.Add(p1,p2));

            Console.ReadKey();
        }
    }
}
