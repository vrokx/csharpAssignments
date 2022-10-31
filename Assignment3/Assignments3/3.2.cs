using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PushPop
{
    public class MyStack
    {
        int size;
        int top = 0;
        int[] arr = new int[20];
        public void GetSizeOfStack()
        {
            WriteLine("Enter Size of Stack");
            size = int.Parse(ReadLine());
        }
        public void Push()
        {
            if (top == (size - 1))
            {
                WriteLine("Stack is Full");
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    WriteLine("Insert element in stack");
                    int element = int.Parse(ReadLine());
                    arr[++top] = element;
                    WriteLine("Item Pushed In The Stack");
                }
            }
        }
        public object Pop()
        {
            if (top == -1)
            {
                WriteLine("Stack Underflow");
                return "No elements";
            }
            else
            {
                return arr[top--];
            }
        }
        public void Display()
        {
            for (int i = top; i > 0; i--)
            {
                WriteLine("Item {0}: |{1}| ", (i), arr[i]);
            }
            ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            //stack.GetSizeOfStack();
            while (true)
            {
                Clear();
                WriteLine("Stack Menu Program");
                WriteLine("1. Enter Size of Stack");
                WriteLine("2. Push operation");
                WriteLine("3. Pop Operation");
                WriteLine("4. Display ");
                WriteLine("5. Exit");
                Write("Enter Your Choice");
                int choice = ToInt32(ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.GetSizeOfStack();
                        break;
                    case 2:
                        stack.Push();
                        break;
                    case 3:
                        WriteLine("Element removed: {0}", stack.Pop());
                        ReadLine();
                        break;
                    case 4:
                        stack.Display();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}