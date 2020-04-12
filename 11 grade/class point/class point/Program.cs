using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_point
{
    class Program
    {
        public class Point
        {
            public double x;
            public double y;
            public double getX()
            {
                Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());
                return this.x = x;
            }
            public double getY()
            {
                Console.Write("Enter y: ");
                double y = double.Parse(Console.ReadLine());
                return this.y = y;
            }
            public void distance()
            {
                /*                double d;
                                double firstSum = x1 - x;
                                firstSum = firstSum * firstSum;
                                double secondSum = y1 - y;
                                secondSum = secondSum * secondSum;
                                d = Math.Sqrt(firstSum)+ Math.Sqrt(secondSum);
                                //d = Math.Sqrt((x1 - x)* (x1 - x)+(y1 - y)* (y1 - y));
                                Console.WriteLine("The distance is equal to {0}",d);*/
            }
        }
        public void distance()
        {
            double d;
            d = Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y));
            Console.WriteLine("The distance is equal to {0}", d);
        }
        static void Main(string[] args)
        {
            Point P = new Point();
            P.getX();
            P.getY();

            Point Q = new Point();
            Q.getX();
            Q.getY();
        }
    }
}
