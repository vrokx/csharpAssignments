using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Assignment7
{
    internal class Program
    {
        public void FileInfo()
        {
            try
            {
                string path = @"D:\MyDirectory";
                string path1 = @"D:\MyDirectory1";
                string path3 = @"D:\New\New1 folder";

                DirectoryInfo dir = new DirectoryInfo(path3);
                // Useful Property Of directory info;
                Console.WriteLine(dir.Name);
                Console.WriteLine(dir.FullName);
                Console.WriteLine(dir.LastAccessTime);
                Console.WriteLine(dir.CreationTime);
                Console.WriteLine(dir.Attributes);
                Console.WriteLine(dir.Parent);
                Console.WriteLine(dir.Root);
                Console.WriteLine(dir.LastWriteTime);

                //  USEFUL PROPERTY OF DIRECTORY INFO
                DirectoryInfo[] dir2 = dir.GetDirectories();
                foreach (var it in dir2)
                {
                    Console.WriteLine(it.FullName);
                    Console.WriteLine(it.GetFiles().Length);
                }
                //string path3 = @"D:\new1\New folder";
                //DirectoryInfo dir = new DirectoryInfo(path3);

                //dir.MoveTo(path1);
                //dir.Delete(true);
                //dir.Create();
                //dir.CreateSubdirectory("Another Directory");
                //Console.WriteLine("Directory deleted");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void CustomerInfo()
        {
            try {
                int emp_id = 2399;
                string name = "Uma Bharti";
                string emp_role = "Analyst3";
                string path = @"F:\Employee_det.txt";
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write);
                Console.WriteLine("File created");
                StreamWriter writer = new StreamWriter(file, Encoding.UTF8);

                writer.WriteLine("Employee_Id : {0}", emp_id);
                writer.WriteLine("Employee_name: {0}", name);
                writer.WriteLine("Employee_role : {0}", emp_role);
                writer.Close();
                file.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        [Serializable]
        internal class Employee
        {

            public int Id;
            public string Name;

            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }
        [Serializable]
        internal class Manager
        {
            int pa;
            int fa;
            int oa;
            public Manager(int pa, int fa, int oa)
            {
                this.pa = pa;
                this.fa = fa;
                this.oa = oa;
            }
        }

        [Serializable]
        internal class MarketingExecutive
        {
            int km;
            float tour_allowance;
            float telephone_all;
            public MarketingExecutive(int km, float tour_allowance, float telephone_all)
            {
                this.km = km;
                this.tour_allowance = tour_allowance;
                this.telephone_all = telephone_all;
            }
        }
        public void Serialization()
        {
            try {
                //string path = @"F:\uma\sample.txt"; //we can create txt file 
                //string path = @"F:\uma\sample.pdf";//we can create pdf file
                // string path = @"F:\uma\sample.png";
                //string path = @"F:\uma\sample.docx";
                string path2 = @"F:\uma\sample3.txt";
                string path1 = @"F:\uma\sample2.txt";
                string path = @"F:\uma\sample.exe";
                Employee emp = new Employee(241, "Uma Bharti");
                Manager M = new Manager(8, 13, 3);
                FileStream fileMa = new FileStream(path2, FileMode.OpenOrCreate);
                MarketingExecutive me = new MarketingExecutive(100, 5.0F, 1000.00F);
                FileStream fileme = new FileStream(path1, FileMode.OpenOrCreate);
                FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();//this is very important for serialization 
                bf.Serialize(fileMa, M);                                           //and deserialization
                bf.Serialize(fileme, me);
                bf.Serialize(filestream, emp);
                filestream.Close();

                Console.WriteLine("File Created Successfully -> " + path);
                Console.WriteLine("fIle Creeated Succesfully->" + path1);
                Console.WriteLine("file created successfuly->" + path2);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }



        public static void Main(string[] args)
        {
            try {
                Program program = new Program();
                Console.WriteLine("Select Program : ");
                Console.WriteLine("1. File Info \n2. Customer Info \n3. Serializable \n4. ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    program.FileInfo();
                }
                else if (userInput == 2)
                {
                    program.CustomerInfo();
                }
                else if (userInput == 3) {
                    program.Serialization();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
    }
}