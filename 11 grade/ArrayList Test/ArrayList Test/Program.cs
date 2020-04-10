using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Create");
            for (int i = 0; i <= 10; i++)
            {
                arrayList.Add(i);
            }
            foreach (int count in arrayList) 
            {
                Console.WriteLine(arrayList[count]);
            }
            Console.WriteLine("Add");
            for (int i = 0; i <= 5; i++)
            {
                arrayList.Add(i);
            }
            foreach (int count in arrayList)
            {
                Console.WriteLine(arrayList[count]);
            }
            Console.WriteLine("remove");
            arrayList.RemoveRange(14,3);
            foreach (int count in arrayList)
            {
                Console.WriteLine(arrayList[count]);
            }
        }
    }
}
