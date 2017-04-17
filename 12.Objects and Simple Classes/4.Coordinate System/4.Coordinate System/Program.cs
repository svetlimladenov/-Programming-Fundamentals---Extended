using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Coordinate_System
{

    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();
            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}",result);

        }
        

        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y,2);
            var distance = Math.Sqrt(squareX + squareY);
            return distance;
        }

        public static Point ReadPoint()
        {
            var readPoint = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            return new Point
            {
                X = readPoint[0],
                Y = readPoint[1]
            };
        }
    }
}
