using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a < 0)
            {
                a = a * -1;
                b = b * -1;
                c = c * -1;
            }
            else
            {
                d = Math.Pow(b, 2)-4*a*c;
                if(d<0)
                {
                    Console.Write("Нямя решение");
                }
                if (d==0)
                {
                    x1 = -b / 2;
                }
                else
                {
                    d = Math.Sqrt(d);
                    x1 = -b - d;
                    x = -b + d;
                }
                Console.WriteLine(x1);
                Console.WriteLine(x);


            }
        }
    }
}
