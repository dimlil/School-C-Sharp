using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Klass
{
    public class Class1
    {
        public string klass;
        public void getNameOfClass()
        {
            Console.Write("Enter class: ");
            this.klass = Console.ReadLine();
        }
        public void printSpisukSUchenici()
        {
            Console.WriteLine("spisuk s uchenici: ");
            foreach (var name in spisucSYchenici)
            {
                Console.WriteLine(name);
                broiYchenici++;
            }
            Console.Write("broi ychenici: ");
            Console.WriteLine(broiYchenici);
        }
        public Class()
        {
            getNameOfClass();
            printSpisukSUchenici();
        }
    }
}
