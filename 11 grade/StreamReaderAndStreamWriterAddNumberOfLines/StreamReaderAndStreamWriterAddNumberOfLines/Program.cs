using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderAndStreamWriterAddNumberOfLines
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
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 10; i++)
                {
                    string text = RandomString(10);
                    sw.Write(text);
                    sw.WriteLine();
                }
                Console.WriteLine("File was created");
            }
            StringBuilder sb = new StringBuilder();
            
            using (StreamReader sr=new StreamReader(path))
            {
                string line = "";
                int count = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(count+"- ");
                    sb.AppendLine(line);
                    count++;
                }
            }
            using (StreamWriter streamWriter=new StreamWriter(path,false))
            {
                streamWriter.Write(sb);
            }
        }
    }
}
