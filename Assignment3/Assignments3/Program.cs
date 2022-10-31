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

        public void setDataEmployee(double Salary)
        {
            this.Salary = Salary;

            this.PetrolAllowance = (Salary * 8)/100;
            this.FoodAllowance = (Salary * 13) / 100;
            this.OtherAllowance = (Salary * 3) / 100;

            this.GrossSalary = Salary + PetrolAllowance + FoodAllowance + OtherAllowance;

            Console.WriteLine(GrossSalary);
        }
        public void CalculateSalary()
        {
            double NetSalary = GrossSalary - PetrolAllowance - FoodAllowance - OtherAllowance;
        }
    }

    class MarketingExecutive
    {

    }

    public static void Main()
    {
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee.Manager emp = new Employee.Manager();
        emp.setDataEmployee(salary);
    }
}
