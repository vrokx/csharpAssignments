using System;

namespace Assignment2
{
    class LitwareLib
    {
        class Employee
        {
            private int EmpNo;
            private string EmpName;
            private double Salary;
            private double HRA;
            private double TA;
            private double DA;
            private double PF;
            private double TDS;
            private double NetSalary;
            private double GrossSalary;


            public void setDataEmployee(int EmpNo, string EmpName, double Salary)
            {
                this.EmpNo = EmpNo;
                this.EmpName = EmpName;
                this.Salary = Salary;
                this.HRA = HRA;
                this.TA = TA;
                this.DA = DA;
                this.PF = PF;
                this.TDS = TDS;
                this.NetSalary = NetSalary;
                this.GrossSalary = GrossSalary;

                if (Salary < 5000)
                {
                    this.HRA = (Salary * 10) / 100;
                    this.TA = (Salary * 5) / 100;
                    this.DA = (Salary * 15) / 100;
                }
                else if (Salary < 10000)
                {
                    this.HRA = (Salary * 15) / 100;
                    this.TA = (Salary * 10) / 100;
                    this.DA = (Salary * 20) / 100;
                }
                else if (Salary < 15000)
                {
                    this.HRA = (Salary * 20) / 100;
                    this.TA = (Salary * 15) / 100;
                    this.DA = (Salary * 25) / 100;
                }
                else if (Salary < 20000)
                {
                    this.HRA = (Salary * 25) / 100;
                    this.TA = (Salary * 20) / 100;
                    this.DA = (Salary * 30) / 100;
                }
                else if (Salary >= 20000)
                {
                    this.HRA = (Salary * 30) / 100;
                    this.TA = (Salary * 25) / 100;
                    this.DA = (Salary * 35) / 100;
                }

                this.GrossSalary = Salary + HRA + TA + DA;
                this.NetSalary = calculateSalary();
            }

            public double calculateSalary()
            {
                this.PF = (GrossSalary * 10) / 100;
                this.TDS = (GrossSalary * 18) / 100;
                this.NetSalary = GrossSalary - (PF + TDS);

                return NetSalary;
            }


            class Library
            {

                private List<Employee> employees = new List<Employee>();

                public void addEmployee(Employee emp)
                {
                    this.employees.Add(emp);
                }

                public void displayEmployees()
                {
                    for (int i = 0; i < employees.Count; i++)
                    {
                        Console.WriteLine("Emp Number: {0}", employees[i].EmpNo);
                        Console.WriteLine("Emp Name: {0}", employees[i].EmpName);
                        Console.WriteLine("Salary: {0}", employees[i].Salary);
                        Console.WriteLine("HRA: {0}", employees[i].HRA);
                        Console.WriteLine("TA: {0}", employees[i].TA);
                        Console.WriteLine("DA: {0}", employees[i].DA);
                        Console.WriteLine("PF: {0}", employees[i].PF);
                        Console.WriteLine("TDS: {0}", employees[i].TDS);
                        Console.WriteLine("Net Salary: {0}", employees[i].NetSalary);
                        Console.WriteLine("Gross Salary: {0}", employees[i].GrossSalary);
                    }
                }

                public static void Main()
                {
                    Library library = new Library();

                    int ch = -1;
                    do
                    {
                        Console.WriteLine("1. Register the employees in company");
                        Console.WriteLine("2. Display employee");
                        Console.WriteLine("3. Exit\n");
                        Console.Write("Your choice: ");
                        ch = int.Parse(Console.ReadLine());

                        if (ch == 1)
                        {

                            Console.WriteLine("Enter Employee Number: ");
                            int ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name: ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary: ");
                            int Salary = int.Parse(Console.ReadLine());

                            Employee emp = new Employee();
                            emp.setDataEmployee(ID, Name, Salary);
                            library.addEmployee(emp);
                        }
                        else if (ch == 2)
                        {
                            library.displayEmployees();
                        }
                        else if (ch == 3)
                        {


                        }
                    } while (ch != 3);

                    Console.ReadKey();

                }
            }
        }

    }
}