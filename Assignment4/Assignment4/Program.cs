using System;
using System.Collections;

class StackException
{
    Stack myStack = new Stack();


    public static void Main()
    {
        StackException stackException = new StackException();
        stackException.myStack.Push("FULL");

        if (stackException.myStack.Count != 0)
        {
            try
            {
                stackException.myStack.Push("PUSH");
                Console.WriteLine("DID PUSH");
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());    
            }
        }
        else
        {
            try
            {
                stackException.myStack.Pop();
                Console.WriteLine("DID POP");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}