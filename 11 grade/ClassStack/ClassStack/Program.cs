using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStack
{
    class Program
    {
        static int Max = 100;
        class Stack<T> where T : IConvertible<T>
        {
            private T[] stArray = new T[Max];
            public int top = 0;
            public Stack()
            {
                //int[] stArray = new int[Max];
            }
            public void Push(T element)
            {
                top = top + 1;
                stArray[top] = element;
                if (top == Max)
                {
                    Console.WriteLine("Stack is full");
                }
            }
            public void Pop()
            {
                //stArray[top] =0; ne ba4ka
                top--;
                if (top == 0)
                {
                    Console.WriteLine("Stack is empty");
                }
            }
            public void Print()
            {
                for (int i = 0; i < stArray.Length; i++)
                {
                    Console.WriteLine(stArray[i]);
                }
            }
        }
    }
}
