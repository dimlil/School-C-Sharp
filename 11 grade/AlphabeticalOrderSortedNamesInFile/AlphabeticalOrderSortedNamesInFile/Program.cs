using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlphabeticalOrderSortedNamesInFile
{
    class Program
    {
        static string pathToNames = @"./Names.txt";
        static string pathToSortedNames = @"./SortedNames.txt";
        static string s = "";
        static void ReadNamesAndPushThemInString()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathToNames))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            s += line + " ";
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }
        static void SortName()
        {
            try
            {
string[] names = s.Split(' ');
            Array.Sort(names);
            using (StreamWriter sw = new StreamWriter(pathToSortedNames, false))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    sw.WriteLine(names[i]);
                }
            }
            Console.WriteLine("Sorted successfully");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
             
        }
        static void Main(string[] args)
        {
            ReadNamesAndPushThemInString();
            SortName();
        }
    }
}
