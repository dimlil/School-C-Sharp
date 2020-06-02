using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOldLinesInFileUsingStreams
{
    class Program
    {
        static string path = @"./WorkingFile.txt";
        static void CreateFile()
        {
            using (StreamWriter sw=new StreamWriter(path,false))
            {
                for (int i = 0; i <= 10; i++)
                {
                    sw.WriteLine("{0}-SomeText",i);
                }
            }
            Console.WriteLine("File was created");
        }
        static void DeleteLines()
        {
            string s = " ";
            using (StreamReader sr=new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    s += line + " ";
                }
            }
            Console.WriteLine(s);
            string[] words = s.Split(' ');
            
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 1; i <= words.Length-2; i++)//from 1 to words.Length-2 becouse on position 0, words.Length-1 and words.Length-2 is Whitespace
                {                
                    if (i%2!=0)//i%2==0 remove even lines
                    {
                        Console.WriteLine(words[i]);
                        sw.WriteLine(words[i]);
                    }
                }
                Console.WriteLine("Odd lines have been deleted");
            }
        }
        static void Main(string[] args)
        {
            CreateFile();
            DeleteLines();
        }
    }
}
