<<<<<<< HEAD
﻿using System.IO.Pipes;
=======
using System.IO.Pipes;
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Banking_Event
{
<<<<<<< HEAD
    #region
=======
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
    public class Account
    {
        private int accountNumber;
        private string customerName;
        private int balance;
        private int amount;
<<<<<<< HEAD

        public void deposit(int amount)
        {
            try
            {
                this.balance += amount;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        public delegate void withdrawdelegate();
        public event withdrawdelegate Transactionfailedevent;
        public void withdraw(int amount)
        {
            try
            {
                if (amount > balance || amount == balance)
                {
                    Console.WriteLine("Transaction failed !");
                }
                else if (amount < balance)
                {
                    this.balance -= amount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void raisemyevent()
        {
            try
            {
                Transactionfailedevent?.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        public void checkbalance()
        {
            try
            {
                Console.WriteLine($"your account balance is {this.balance}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        Account(int accountno, string customername)
        {
            try
            {
                this.customerName = customername;
                this.accountNumber = accountno;
                balance = 5000;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Banking Application");
                Console.WriteLine("Enter your Account Number");
                int accountno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                string customername = Console.ReadLine();

                Account ac1 = new Account(accountno, customername);
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
                    else if (option == 4)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
=======
        
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
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
            }
        }

        private static void Ac1_Transactionfailedevent()
        {
<<<<<<< HEAD
            try {
                Console.WriteLine("transaction failed !");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }

    }
    #endregion
}
=======
            Console.WriteLine("transaction failed !");
        }

        
    }
}
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
