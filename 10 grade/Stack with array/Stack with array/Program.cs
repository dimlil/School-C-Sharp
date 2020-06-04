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
            stack[top + 1]=element;
            top++;
        }
        static void Pop()
        {
            stack[top] = 0;
            top--;
        }
        static void Empty()
        {
            if(top==0){
                Console.WriteLine("Stack is empty");
            }
        }
        static void Full()
        {
            if (top>Max)
            {
                Console.WriteLine("Stack is full");
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
        }
    }
}
