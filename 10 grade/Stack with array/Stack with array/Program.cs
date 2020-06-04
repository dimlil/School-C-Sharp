using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_with_array
{
    class Program
    {
        static int Max = 5;
        static int[] stack = new int[Max];
        static int top = 0;
        static void Push(int element)
        {
            if (Full())
            {
                Full();
            }
            else
            {
                stack[top] = element;
                top++;
            }

        }
        static void Pop()
        {
            stack[top] = 0;
            top--;
        }
        static void Empty()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack is empty");

            }
        }
        static bool Full()
        {
            if (top >= Max)
            {
                Console.WriteLine("Stack is full");
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Print()
        {
            for (int i = 0; i < stack.Length; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
        static void Main(string[] args)
        {
            Empty();
            Push(10);
            Push(1);
            Push(20);
            Push(40);
            Push(50);
            Full();
            Print();
        }
    }
}
