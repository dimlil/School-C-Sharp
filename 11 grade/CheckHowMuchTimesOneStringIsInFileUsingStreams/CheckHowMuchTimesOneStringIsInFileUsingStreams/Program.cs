using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheckHowMuchTimesOneStringIsInFileUsingStreams
{
    class Program
    {
        static string path = @"./WorkingFile.txt";
        static void Check(string search)
        {         
            int counter = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    if (line==search)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("Word {0} occurs {1} times",search,counter);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter text that you search for: ");
            string input = Console.ReadLine();
            Check(input);
        }
    }
}
