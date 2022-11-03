using System;
using static System.Console;
using static System.Convert;

class Employee
{
    #region
    class Manager
    {
        #region
        private double Salary;
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double GrossSalary;
        private double NetSalary;

        public void setDataEmployee(double Salary)
        {
            try {
                this.Salary = Salary;

                this.PetrolAllowance = (Salary * 8) / 100;
                this.FoodAllowance = (Salary * 13) / 100;
                this.OtherAllowance = (Salary * 3) / 100;

                GrossSalary = Salary + PetrolAllowance + FoodAllowance + OtherAllowance;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void CalculateSalary()
        {
            try {
                NetSalary = GrossSalary - PetrolAllowance - FoodAllowance - OtherAllowance;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void displaySalaryManager()
        {
            try {
                Console.WriteLine("Gross Salary : " + GrossSalary);
                Console.WriteLine("Net Salary : " + NetSalary);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        #endregion
    }

    class MarketingExecutive
    {
        #region
        private int KmTravel = 10;
        private int TourAllowance;
        private int TelephoneAllowance;
        private double GrossSalary;
        private double NetSalary;

        public void setDataEmployee(double Salary)
        {
            try {
                TourAllowance = 5 * KmTravel;
                TelephoneAllowance = 1000;

                GrossSalary = Salary + TourAllowance + TelephoneAllowance;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        public void CalculateSalary()
        {
            try
            {
                NetSalary = GrossSalary - TourAllowance - TelephoneAllowance;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void displaySalaryMarketingExecutive()
        {
            try {
                Console.WriteLine("Gross Salary : " + GrossSalary);
                Console.WriteLine("Net Salary : " + NetSalary);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        #endregion
    }

    public class MyStack
    {
        #region
        int size;
        int top = 0;
        int[] arr = new int[20];
        public void GetSizeOfStack()
        {
            try {
                WriteLine("Enter Size of Stack");
                size = int.Parse(ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void Push()
        {
            try {
                if (top == (size - 1))
                {
                    WriteLine("Stack is Full");
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        WriteLine("Insert element in stack");
                        int element = int.Parse(Console.ReadLine());
                        arr[++top] = element;
                        WriteLine("Item Pushed In The Stack");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public object Pop()
        {
            try
            {
                if (top == -1)
                {
                    WriteLine("Stack Underflow");
                    Console.WriteLine("No elements");
                }
                else
                {
                    Console.WriteLine(arr[top--]);
                }  
            }

            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
            return ".";
        }   
            public void Display()
            {
            try
            {
                for (int i = top; i > 0; i--)
                {
                    WriteLine("Item {0}: |{1}| ", (i), arr[i]);
                }
                ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
            }
        #endregion
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("Select Program you want to run : ");
            Console.WriteLine("1. Employee System \n2. Stack Application");
            int menuInput = Convert.ToInt32(Console.ReadLine());
            if (menuInput == 1)
            {
                Console.WriteLine("Select Employee Type : ");
                Console.WriteLine("1. Manager \n2. Marketing Execuitve ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("Enter Salary : ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    Employee.Manager emp = new Employee.Manager();
                    emp.setDataEmployee(salary);
                    emp.CalculateSalary();
                    emp.displaySalaryManager();
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Enter Salary : ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    Employee.MarketingExecutive emp = new Employee.MarketingExecutive();
                    emp.setDataEmployee(salary);
                    emp.CalculateSalary();
                    emp.displaySalaryMarketingExecutive();
                }
            }
            else if (menuInput == 2)
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
                    int choice = Convert.ToInt32(ReadLine());
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
        catch (Exception e)
        {
            Console.WriteLine("Error : " + e);
        }
    }
    #endregion
}
