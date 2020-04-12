using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SreamReaderAndSreamWriterMoveTwoFilesInThird
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
            string path1 = @"./text1.txt";
            string path2 = @"./text2.txt";
            string path3 = @"./text3.txt";
            using (StreamWriter sw = new StreamWriter(path1, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + "- ");
                    string text = RandomString(10);
                    sw.Write(text);
                    sw.WriteLine();
                }
                Console.WriteLine("File was created");
            }            
            using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + "- ");
                    string text = RandomString(10);
                    sw.Write(text);
                    sw.WriteLine();
                }
                Console.WriteLine("File was created");
            }
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr=File.OpenText(path1))
            {
                string line = "";
                while ((line=sr.ReadLine())!=null)
                {
                    sb.AppendLine(line);
                }
            }
            sb.AppendLine();
            using (StreamReader sr=File.OpenText(path2))
            {
                string line = "";
                while ((line=sr.ReadLine())!=null)
                {
                    sb.AppendLine(line);
                }
            }
            using (StreamWriter sw=new StreamWriter(path3,false))
            {
                sw.WriteLine(sb);
            }
        }
    }
}
