using System;

class Employee
{
    class Manager
    {
        private double Salary;
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double GrossSalary;
        private double NetSalary;

        public void setDataEmployee(double Salary)
        {
            this.Salary = Salary;

            this.PetrolAllowance = (Salary * 8)/100;
            this.FoodAllowance = (Salary * 13) / 100;
            this.OtherAllowance = (Salary * 3) / 100;

            GrossSalary = Salary + PetrolAllowance + FoodAllowance + OtherAllowance;
        }
        public void CalculateSalary()
        {
            NetSalary = GrossSalary - PetrolAllowance - FoodAllowance - OtherAllowance;
        }
        public void displaySalaryManager()
        {
            Console.WriteLine("Gross Salary : " + GrossSalary);
            Console.WriteLine("Net Salary : " + NetSalary);
        }
    }

    class MarketingExecutive
    {
        private int KmTravel = 10;
        private int TourAllowance;
        private int TelephoneAllowance;
        private double GrossSalary;
        private double NetSalary;

        public void setDataEmployee(double Salary)
        {
            TourAllowance = 5 * KmTravel;
            TelephoneAllowance = 1000;

            GrossSalary = Salary + TourAllowance + TelephoneAllowance;
        }

        public void CalculateSalary()
        {
            NetSalary = GrossSalary - TourAllowance - TelephoneAllowance;
        }
        public void displaySalaryMarketingExecutive()
        {
            Console.WriteLine("Gross Salary : " + GrossSalary);
            Console.WriteLine("Net Salary : " + NetSalary);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Select Employee Type : ");
        Console.WriteLine("1. Manager \n2. Marketing Execuitve ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if(userInput == 1)
        {
            Console.WriteLine("Enter Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee.Manager emp = new Employee.Manager();
            emp.setDataEmployee(salary);
            emp.CalculateSalary();
            emp.displaySalaryManager();
        }
        else if(userInput == 2)
        {
            Console.WriteLine("Enter Salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee.MarketingExecutive emp = new Employee.MarketingExecutive();
            emp.setDataEmployee(salary);
            emp.CalculateSalary();
            emp.displaySalaryMarketingExecutive();
        }

    }
}
