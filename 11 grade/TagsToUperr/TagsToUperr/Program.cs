using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TagsToUperr
{
    //This program use Regex to find a word between <upcase></upcase> and make it ToUperr case
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string result = "";
            Regex pattern = new Regex(@"[a-z][a-z][^<upcase></upcase>][a-z]*");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith("<") || words[i].Contains("<"))
                {
                    MatchCollection matches = pattern.Matches(words[i]);
                    foreach (var item in matches)
                    {
                        result += item.ToString().ToUpper() + " ";
                    }
                }
                else
                {
                    result += words[i] + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
