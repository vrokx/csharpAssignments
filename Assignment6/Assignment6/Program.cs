using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Banking_Event
{
    public class Account
    {
        private int accountNumber;
        private string customerName;
        private int balance;
        private int amount;
        
        public void deposit(int amount)
        {
                this.balance += amount;
            
        }

        public delegate void withdrawdelegate();
        public event withdrawdelegate Transactionfailedevent;
        public void  withdraw(int amount)
        {
            if(amount>balance || amount == balance)
            {
                Console.WriteLine("Transaction failed !");
            }
            else if(amount < balance)
            {
                this.balance -= amount;
            }
        }
        public void raisemyevent()
        {
            Transactionfailedevent?.Invoke();
        }
       
        
        public void checkbalance()
        {
            Console.WriteLine($"your account balance is {this.balance}");
        }

        

        Account(int accountno,string customername)
        {
            this.customerName = customername;
            this.accountNumber = accountno;
            balance =5000;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Banking Application");
            Console.WriteLine("Enter your Account Number");
            int accountno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name");
            string customername = Console.ReadLine();
            

            Account ac1 = new Account(accountno,customername);
            ac1.Transactionfailedevent += Ac1_Transactionfailedevent;



            while (true)
            {
                Console.WriteLine("select the operation you want to perform : 1.deposit 2.withdraw 3.chcek balance 4.exit ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter your amount to deposit");
                    int amount = int.Parse(Console.ReadLine());
                    ac1.deposit(amount);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter your amount to withdraw");
                    int amount = int.Parse(Console.ReadLine());
                    ac1.withdraw(amount);

                }
                else if (option == 3)
                {
                    ac1.checkbalance();

                }
                else if(option==4)
                {
                    break;
                }
            }
        }

        private static void Ac1_Transactionfailedevent()
        {
            Console.WriteLine("transaction failed !");
        }

        
    }
}
