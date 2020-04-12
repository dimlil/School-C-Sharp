using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_autor_and_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();
            Dictionary<string, ArrayList> dictionary = new Dictionary<string, ArrayList>();
            string key = " ";
            string value = "";
            int i = 0;
            while(i<2)
            {
                key = " ";
                value = " ";
                Console.Write("key: ");
                key = Console.ReadLine();
                Console.WriteLine("values: ");
                while (value==" ") 
                {
                    value = Console.ReadLine();
                    if (value == "stop" || value == "s" || value == "Stop" || value == "end" || value == "End")
                    {
                        break;
                    }
                    books.Add(value);
                    value = " ";
                }
                dictionary.Add(key,books);
                i++;
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, ArrayList> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}",kvp.Key);
                foreach (object obj in kvp.Value) 
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
        }
    }
}
