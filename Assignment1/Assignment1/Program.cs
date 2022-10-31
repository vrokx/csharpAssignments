using System;
using System.Xml.Linq;

namespace Assignment1
{
    class Program
    {
        static void Calculator()
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Action You Want to Perform: + or - or * or /");
            string action = Convert.ToString(Console.ReadLine());

            switch (action)
            {
                case "+":
                    var addition = num1 + num2;
                    Console.WriteLine(addition);
                    break;
                case "-":
                    var subtraction = num1 - num2;
                    Console.WriteLine(subtraction);
                    break;
                case "*":
                    var multiplication = num1 * num2;
                    Console.WriteLine(multiplication);
                    break;
                case "/":
                    var division = num1/num2;
                    Console.WriteLine(division);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }

        static void AverageMarks()
        {
            Console.WriteLine("Enter marks of students to calculate average marks");
            Console.WriteLine("1st Student's Mark");
            int student1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2nd Student's Mark");
            int student2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3rd Student's Mark");
            int student3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4th Student's Mark");
            int student4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5th Student's Mark");
            int student5 = Convert.ToInt32(Console.ReadLine());

            var average = (student1 + student2 + student3 + student4 + student5) / 5;

            Console.WriteLine("Average marks of five students = " + average);
        }
        
        static void SumOfArray()
        {
            Console.WriteLine("Enter five numbers to sum");
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = arr.Sum();
            Console.WriteLine("Total of array :" + total);
        }

        static void SwapIntegers()
        {
            Console.WriteLine("Enter Two Integers to Swap them");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            int SecondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers Before Swap");
            Console.WriteLine("First Number : " + FirstNum + " Second Number : " + SecondNum);

            int temp = FirstNum;
            FirstNum = SecondNum;
            SecondNum = temp;

            Console.WriteLine("Numbers After Swap");
            Console.WriteLine("First Number : " + FirstNum + " Second Number : " + SecondNum);
        }

        static void CircleMethod()
        {
            Console.WriteLine("Enter radius of circle to get Area and Circumference : ");
            int radius = Convert.ToInt32(Console.ReadLine());

            float pie = 3.14f;
            float area = (pie * (radius * radius));
            float circumference = (2 * pie * radius);

            Console.WriteLine("Area of Circle : " + area);
            Console.WriteLine("Circumference of Circle : " + circumference);
        }

        public enum BookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }
        struct Book
        {
            public int bookId ;
            public string title;
            public int price;
            public string bookType; 
        };

        static void BookInfo()
        {
            int Nobook = 50;
            Book[] books = new Book[Nobook];
            int i, j, num, t = 0;

            Console.WriteLine("How many books you want to store? : ");
            int input = Convert.ToInt32(Console.ReadLine()); ;

            Console.Write("Enter {0} elements in the array \n\n", input);

            for (j = 0; j < input; j++)
            {
                Console.WriteLine("Information of book {0} :", t);

                Console.Write("Enter Id of the book : ");
                books[j].bookId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Title of the book : ");
                books[j].title = Console.ReadLine();


                Console.WriteLine("**************************************");


                Console.WriteLine("Select Type of the book : ");

                foreach (int b in Enum.GetValues(typeof(BookType)))
                Console.WriteLine((BookType)b);
                Console.Write("Enter Book Type : ");
                books[j].bookType = Console.ReadLine();


                Console.WriteLine("**************************************");

                Console.Write("Enter the Price of the book : ");
                books[j].price = Convert.ToInt32(Console.ReadLine());
                t++;
                Console.WriteLine();
            }

            for (i = 0; i < input; i++)
            {
                Console.WriteLine("{0}: BookId = {1},  Title = {2} ,BookType = {3}, Price = {4} ", i + 1, books[i].bookId, books[i].title, books[i].bookType, books[i].price);
            }

        }

            static void Main(string[] args)
            {
                Console.WriteLine("Method Names :");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. AverageMarks");
                Console.WriteLine("3. SumOfArray");
                Console.WriteLine("4. SwapIntegers");
                Console.WriteLine("5. CircleMethod");
                Console.WriteLine("6. BookInfo");
                Console.WriteLine("Enter Method Number to select Method from menu : ");
                
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Calculator();
                }
                else if (input == 2)
                {
                    AverageMarks();
                }
                else if (input == 3)
                {
                    SumOfArray();
                }
                else if (input == 4)
                {
                    SwapIntegers();
                }
                else if (input == 5)
                {
                    CircleMethod();
                }
                else if (input == 6)
                {
                    BookInfo();
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
    }