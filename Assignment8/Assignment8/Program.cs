using System.Diagnostics;
using System.Reflection;
using System.IO;


namespace Reflection_Assembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
