using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClassAndStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw=new StreamWriter(@"./something.txt",true))
            {
                sw.Write("Helloooo");
            }
        }
    }
}
