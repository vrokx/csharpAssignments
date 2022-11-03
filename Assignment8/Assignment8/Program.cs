<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectioDemo
=======
using System.Diagnostics;
using System.Reflection;
using System.IO;


namespace Reflection_Assembly
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            try {
                Type T = Type.GetType("ReflectioDemo.Employee");
                Console.WriteLine("FullName of Type = {0}", T.FullName);
                Console.WriteLine("Name of Type = {0} ", T.Name);
                Console.WriteLine("Namespace of type : {0} ", T.Namespace);
                PropertyInfo[] properties = T.GetProperties();
                Console.WriteLine("Id available are :");
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.Name);
                    Console.WriteLine(property.PropertyType.Name);
                    Console.WriteLine(property.PropertyType.Name + " " + property.Name);
                }

                MethodInfo[] method = T.GetMethods();
                Console.WriteLine("Method available are :");
                foreach (MethodInfo meth in method)
                {
                    Console.WriteLine(meth.Name);
                }
                Console.WriteLine("Construtor availabe are :");

                ConstructorInfo[] constructors = T.GetConstructors();
                foreach (ConstructorInfo constructor in constructors)
                {
                    Console.WriteLine(constructor.Name);
                }
                Console.ReadLine();


                Employee employee = new Employee();

            }catch(Exception e){
                Console.WriteLine("Error : " + e);
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Employee()
        {
            this.Id = -1;
            this.Name = string.Empty;

        }
        public void PrintID()
        {
            try
            {
                Console.WriteLine("ID = {0}", this.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
        public void PrintName()
        {
            try
            {
                Console.WriteLine("Name = {0}", this.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
        }
    }
}
=======
            Assembly asm = Assembly.LoadFrom(@"C:\Users\vrokx\source\repos\Reflection_Assembly\MyAssembly\bin\Debug\net6.0\MyAssembly.dll");
            Type t = asm.GetType("MyAssembly.MyClass");

            
            var methodInfo = t.GetMethod("MyMethod", new Type[] { typeof(int), typeof(string) });
            if (methodInfo == null)
            {
                
                throw new Exception("MethodnotFound");
            }

            
            object[] constructorParameters = new object[2];
            constructorParameters[0] = 100; 
            constructorParameters[1] = 100;   

            
            var o = Activator.CreateInstance(t, constructorParameters);

            
            object[] parameters = new object[2];
            parameters[0] = 26;           
            parameters[1] = "this is a text";   

            
            var r = methodInfo.Invoke(o, parameters);
            Console.WriteLine(r);

            var methodInfoStatic = t.GetMethod("StaticMethod");
            if (methodInfoStatic == null)
            {
                
                throw new Exception("InvalidMethoodCallException");
            }

            
            object[] staticParameters = new object[2];
            staticParameters[0] = 12;
            staticParameters[1] = 3.14159f;

            
            methodInfoStatic.Invoke(o, staticParameters);

        }
    }
}
>>>>>>> b5fbcfff48c6832bf212674db1aeec6b2db7389c
