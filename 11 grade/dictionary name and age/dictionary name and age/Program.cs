using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_name_and_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            string key = " ";
            int value = 0;

            for (int i = 0; i < 5; i++)
            {
                key = " ";
                value = 0;
                Console.Write("key: ");
                key = Console.ReadLine();
                Console.Write("value: ");
                value = int.Parse(Console.ReadLine());
                dictionary.Add(key,value);
            }

            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}
