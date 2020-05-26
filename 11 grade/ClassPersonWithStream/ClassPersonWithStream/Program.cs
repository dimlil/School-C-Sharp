using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassPersonWithStream
{
    class Program
    {
        static string pathToDB = @"./db.txt";

        class Person
        {
            private string name = "";
            private int height = 0;
            private int weight = 0;
            private int age = 0;

            public Person()
            {
                GetName();
                GetHeight();
                GetWeight();
                GetAge();
                addToDB();
                Print();
            }
            public void addToDB()
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(pathToDB, true))
                    {
                        sw.Write(this.name);
                        sw.WriteLine(":{");
                        sw.Write("height: ");
                        sw.WriteLine(this.height);
                        sw.Write("weight: ");
                        sw.WriteLine(this.weight);
                        sw.Write("age: ");
                        sw.WriteLine(this.age);
                        sw.WriteLine("}");
                        sw.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Successfyly add to db");
            }
            public void GetName()
            {
                Console.Write("Enter name: ");
                this.name = Console.ReadLine();
            }
            public void GetHeight()
            {
                try
                {
                    Console.Write("Enter height: ");
                    this.height = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number");
                    Console.Write("Enter height: ");
                    this.height = int.Parse(Console.ReadLine());
                }

            }
            public void GetWeight()
            {
                try
                {
                    Console.Write("Enter weight: ");
                    this.weight = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number");
                    Console.Write("Enter weight: ");
                    this.weight = int.Parse(Console.ReadLine());
                }
            }
            public void GetAge()
            {
                try
                {
                    Console.Write("Enter age: ");
                    this.age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input must be positive number");
                    Console.Write("Enter age: ");
                    this.age = int.Parse(Console.ReadLine());
                }
            }
            public void Print()
            {
                Console.WriteLine("Succesfuly created persone {0} with height {1}, weight{2} and {3} years old", this.name, this.height, this.weight, this.age);
            }
        }
        static void CreateAPersone()
        {
            //string name = Console.ReadLine();
            dynamic name = new Person();
        }

        static void ReadDB()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathToDB))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        static void Main(string[] args)
        {
            string command = "";
            Console.Write("Ente command(Create new Person/Log DataBase to Console/stop or end for stop the program): ");
            command = Console.ReadLine();
            while (command != "stop" && command != "end")
            {
                if (command.ToLower() == "create new person" || command.ToLower() == "create")
                {
                    CreateAPersone();
                }
                if (command.ToLower() == "log database to console")
                {
                    ReadDB();
                }
                if (command.ToLower() != "create new person" && command.ToLower() != "log database to console")
                {
                    Console.WriteLine("wrong command, please try again");
                }
                Console.Write("Ente command(Create new Person/Log DataBase to Console/stop or end for stop the program): ");
                command = Console.ReadLine();
            }
        }
    }
}
