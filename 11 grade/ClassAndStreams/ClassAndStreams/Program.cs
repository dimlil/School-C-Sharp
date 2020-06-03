using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClassAndStreams
{
    class Program
    {
        static string nameToDB = "";
        static int ageToDB = 0;
        static int weightToDB = 0;
        static int heightToDB = 0;
        class Person
        {
            private string name = "";
            private int age = 0;
            private int weight = 0;
            private int height = 0;

            public Person()
            {
                GetName();
                GetHeight();
                GetWeight();
                GetAge();
                Print();
            }

            public void GetName()
            {
                Console.Write("Enter name: ");
                this.name = Console.ReadLine();
                nameToDB = this.name;
            }
            public void GetHeight()
            {
                try
                {
                    Console.Write("Enter height: ");
                    this.height = int.Parse(Console.ReadLine());
                    heightToDB = this.height;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number");
                    Console.Write("Enter height: ");
                    this.height = int.Parse(Console.ReadLine());
                    heightToDB = this.height;
                }

            }
            public void GetWeight()
            {
                try
                {
                    Console.Write("Enter weight: ");
                    this.weight = int.Parse(Console.ReadLine());
                    weightToDB = this.weight;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number ");
                    Console.Write("Enter weight: ");
                    this.weight = int.Parse(Console.ReadLine());
                    weightToDB = this.weight;
                }
            }
            public void GetAge()
            {
                try
                {
                    Console.Write("Enter age: ");
                    this.age = int.Parse(Console.ReadLine());
                    ageToDB = this.age;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number");
                    Console.Write("Enter age: ");
                    this.age = int.Parse(Console.ReadLine());
                    ageToDB = this.age;
                }
            }
            public void Print()
            {
                Console.WriteLine("Succesfuly created persone {0} with height {1}, weight {2} and {3} years old", this.name, this.height, this.weight, this.age);
            }
        }
        static void CreateAPerson()
        {
            dynamic person = new Person();
        }
        static void WriteFile()
        {
            Console.Write("Enter name of new file: ");
            string input = Console.ReadLine();
            string path = @"./" + input + ".txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Person: {0}",nameToDB);
                sw.WriteLine("height: {0}",heightToDB);
                sw.WriteLine("Weight: {0}", weightToDB);
                sw.WriteLine("Age: {0}",ageToDB);
                sw.WriteLine();
            }
        }
        static void ReadFile()
        {
            Console.Write("Which file do you want to read and print in console: ");
            string input = Console.ReadLine();
            string path = @"./" + input + ".txt";
            using (StreamReader sr=new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        static void AppendFile()
        {
            Console.Write("In which file do you want to append information: ");
            string input = Console.ReadLine();
            string path = @"./" + input+".txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Person: {0}", nameToDB);
                sw.WriteLine("height: {0}", heightToDB);
                sw.WriteLine("Weight: {0}", weightToDB);
                sw.WriteLine("Age: {0}", ageToDB);
                sw.WriteLine();
            }
        }
        static void Menu()
        {
            Console.WriteLine("Select 1-4(create/write/read/append) /5-End:");
            int selector = int.Parse(Console.ReadLine());

            while (selector != 5)
            {
                if (selector == 1)
                {
                    CreateAPerson();
                }
                else
                {
                    if (selector == 2)
                    {
                        WriteFile();
                    }
                    else
                    {
                        if (selector == 3)
                        {
                            ReadFile();
                        }
                        else
                        {
                            if (selector == 4)
                            {
                                AppendFile();
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine("Select 1-4(create/write/read/append) /5-End:");
                selector = int.Parse(Console.ReadLine());

            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
