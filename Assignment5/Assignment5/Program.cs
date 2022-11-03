using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Assignment5
{
    #region
    class ArrayOperations
    {
        int[] intArray = { 7, 9, 5, 6, 8 };
        string[] stringArray = { "Volvo", "BMW", "Ford", "Mazda" };

        public void ArrayOperationsMethod()
        {
            try
            {
                int[] newIntArray = new int[5];

                Console.WriteLine("Old Array Before Copy : ");
                foreach (var item in newIntArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("Array Which will be copied : ");
                foreach (var item in intArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
                intArray.CopyTo(newIntArray, 0);
                Console.WriteLine("New Array After Copy : ");
                foreach (var item in newIntArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("Sort Array : ");
                Array.Sort(intArray);
                foreach (var item in intArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("Clear Array : ");
                Array.Clear(intArray, 1, 2);
                foreach (var item in intArray)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("Reverse Array : ");
                Array.Reverse(intArray);
                foreach (var item in intArray)
                {
                    Console.Write(item.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        #region
        class EmployeeLists
        {
            ArrayList emp = new ArrayList();
            public void addEmployee()
            {
                try
                {
                    Console.WriteLine("Enter Employee Number : ");
                    int userEmpNo = Convert.ToInt32(Console.ReadLine());
                    emp.Add("Emp Number :" + userEmpNo);

                    Console.WriteLine("Enter Employee Name : ");
                    string userEmpName = Convert.ToString(Console.ReadLine());
                    emp.Add("Emp Name : " + userEmpName);

                    Console.WriteLine("Enter Employee Salary : ");
                    int userEmpSalary = Convert.ToInt32(Console.ReadLine());
                    emp.Add("Emp Salary : " + userEmpSalary);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                }

            }
            public void displayEmployee()
            {
                try
                {
                    foreach (var i in emp)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                }
            }
        }
        #endregion

        #region
        class MyStack
        {

            Stack myStack = new Stack();
            public void pushStack(object input)
            {
                try
                {
                    myStack.Push(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                }
            }
            public void popStack()
            {
                try
                {
                    myStack.Pop();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                }
            }
            public void printStack()
            {
                try
                {
                    foreach (var item in myStack)
                        Console.WriteLine(item + ",");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                }
            }
        }
        #endregion

        //class Player
        //{
        //    string playerName = "temp";
        //    int runsScored = 0;
        //    class Team
        //    {
        //         Array[] Player = {playerName , runsSCored};
        //    }
        //}


        public static void Main()
        {
            try {
                Console.WriteLine("Choose Method to run : ");
                Console.WriteLine("1. Array Operations \n2. Employee List \n3. My Stack \n4. Player Details ");
                Console.WriteLine("Enter Method Number : ");

                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    ArrayOperations arrayOperations = new ArrayOperations();

                    arrayOperations.ArrayOperationsMethod();
                }
                else if (userInput == 2)
                {
                    EmployeeLists employeeLists = new EmployeeLists();
                    Console.WriteLine("1. Add Employee \n2. Display Employee");
                    int userNewInput = Convert.ToInt32(Console.ReadLine());

                    if (userNewInput == 1)
                    {
                        int answer = 1;
                        do
                        {
                            employeeLists.addEmployee();

                            Console.WriteLine("Do you Want to Add more Employees?");
                            Console.WriteLine("1. Yes \n2. No");

                            answer = Convert.ToInt32(Console.ReadLine());

                            if (answer == 2)
                            {
                                employeeLists.displayEmployee();
                            }

                        } while (answer == 1);

                    }
                    else if (userNewInput == 2)
                    {
                        employeeLists.displayEmployee();
                    }
                    else { Console.WriteLine("Error"); }
                }
                else if (userInput == 3)
                {
                    MyStack myStack = new MyStack();
                    int answer = 1;

                    do
                    {

                        Console.WriteLine("Stack Before : ");
                        myStack.printStack();

                        Console.WriteLine("Enter something to push : ");
                        var input = Console.ReadLine();
                        myStack.pushStack(input);

                        Console.WriteLine("Stack After : ");
                        myStack.printStack();

                        Console.WriteLine("Do you Want to push More in Stack?");
                        Console.WriteLine("1. Yes \n2. No\n3. Pop");

                        answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == 2)
                        {
                            Console.WriteLine("Stack After : ");
                            myStack.printStack();
                        }
                        else if (answer == 3)
                        {
                            Console.WriteLine("Stack Before : ");
                            myStack.printStack();

                            myStack.popStack();

                            Console.WriteLine("Stack After : ");
                            myStack.printStack();

                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                        }
                    } while (answer == 1);

                }
                else if (userInput == 4)
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
    }
    #endregion
}