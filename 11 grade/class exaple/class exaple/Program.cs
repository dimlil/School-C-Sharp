using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_exaple
{
    class Program
    {
        public class Example2
        {
            public int age;
            public string name;
            public string Name(string name)
            {
                return this.name = name;
            }
            public int Age(int age)
            {
                return this.age = age;
            }
            public void Print()
            {
                Console.WriteLine("{0} is {1} age old", name, age);
            }
        }
        public class Example
        {
            public int age;
            public string name;
            public Example(string s,int n)
            {
                name = s;
                age = n;
            }
            public void Print()
            {
                Console.WriteLine("{0} is {1} age old",name,age);
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string s = Console.ReadLine();
            Console.Write("Enter a age: ");
            int n = int.Parse(Console.ReadLine());
            Example ex1 = new Example(s, n);
            Example2 ex2 = new Example2();
            string s1 = "Peter";
            int n1 = 20;
            ex2.Name(s1);
            ex2.Age(n1);
            ex1.Print();
            ex2.Print();
        }
    }
}
