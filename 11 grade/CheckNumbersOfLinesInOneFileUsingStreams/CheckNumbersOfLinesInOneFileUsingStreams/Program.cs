using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheckNumbersOfLinesInOneFileUsingStreams
{
    class Program
    {
        static string pathToText = @"./text.txt";
        static string pathToResult = @"./result.txt";

        static void Create()
        {
            using (StreamWriter sw = new StreamWriter(pathToText, false))
            {
                for (int i = 0; i <= 10; i++)
                {
                    sw.WriteLine("{0}-SomeText", i);
                }
            }
            Console.WriteLine("File was created");
        }
        static int counter = 0;
        static void CheckLines()
        {
            using (StreamReader sr=new StreamReader(pathToText))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        counter++;
                    }
                }
            }
        }
        static void AddResul()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathToResult, true))
                {
                    sw.WriteLine("File has {0} lines",counter - 1);//conter -1 becouse file has one whitespace
                }
                Console.WriteLine("Result addded successfuly");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
 
        }
        static void Main(string[] args)
        {
            Create();
            CheckLines();
            AddResul();
        }
    }
}
