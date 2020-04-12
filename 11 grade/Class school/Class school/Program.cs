using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_school
{
    class Program
    {
        static int broiYchenici=0;
        /*static String[] spisucSYchenici = new String[broiYchenici];*/
        static List<string> spisucSYchenici = new List<string>();
        class Prepodawatel
        {
            
        }
        class Ychenik
        {
            public string name;
            public string paralelka;
            public String [] disciplini = new String[15];

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
                    if (input=="Stop"|| input == "stop")
                    {
                        break;
                    }
                    else
                    {
                        this.disciplini[i] = input;
                    }
                }
            }

            public Ychenik() 
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
                    Console.WriteLine(disciplini[i]);
                }
                Console.WriteLine();
            }
        }
        class Class
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
        class Disciplina
        {
            
        }
        static void Main(string[] args)
        {
            Ychenik firstS = new Ychenik();
            Ychenik secondS = new Ychenik();
            Ychenik thirtS = new Ychenik();
            Class firstC = new Class();

            Console.WriteLine("spis");

            spisucSYchenici.RemoveRange(0,broiYchenici);
            foreach (var name in spisucSYchenici)
            {
                Console.WriteLine(name);
            }
        }
    }
}
