using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_School
{
    public class Student
    {
        static int broiYchenici = 0;
        /*static String[] spisucSYchenici = new String[broiYchenici];*/
        static List<string> spisucSYchenici = new List<string>();

        public string name;
        public string paralelka;
        public String[] disciplini = new String[15];

        public void GetName()
        {
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
        }
        public void GetParalelka()
        {
            Console.Write("Enter paralelka: ");
            this.paralelka = Console.ReadLine();
        }
        public void GetDisciplini()
        {
            Console.WriteLine("Enter predmeti (dokato ne napishes stop): ");
            string input = "";
            for (int i = 0; i < 15; i++)
            {
                input = Console.ReadLine();
                if (input == "Stop" || input == "stop")
                {
                    break;
                }
                else
                {
                    this.disciplini[i] = input;
                }
            }
        }

        public Student()
        {
            GetName();
            GetParalelka();
            GetDisciplini();
            setInClass();
            Print();
        }
        public void setInClass()//Push the student in spisucSYchenici
        {
            spisucSYchenici.Add(name);
        }
        public void Print()
        {
            Console.WriteLine("Ychenika:");
            Console.WriteLine(name);
            Console.WriteLine(paralelka);
            for (int i = 0; i < this.disciplini.Length; i++)
            {
                if (disciplini[i] == null)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine(disciplini[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
