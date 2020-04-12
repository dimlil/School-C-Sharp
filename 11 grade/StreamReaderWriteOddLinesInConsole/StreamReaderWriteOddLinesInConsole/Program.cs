using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderWriteOddLinesInConsole
{
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            string path = @"./text.txt";
            using (StreamWriter sw=new StreamWriter(path,false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i+"- ");
                    string text = RandomString(10);
                    sw.Write(text);
                    sw.WriteLine();
                }
                Console.WriteLine("File was created");
            }
            using (StreamReader sr=new StreamReader(path, System.Text.Encoding.Default)) 
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                }
            }
        }
    }
}
