using System;
using System.IO;
using System.Runtime;
using System.Text;

class FileOperations
{
    string path = @"E:\Degreed\csharp\Assignments\Assignment6\TextFiles\one.txt";
    class DirectoryInfo
    {

    }

    class Directory
    {

    }

    class Files
    {
        string text = System.IO.File.ReadAllText(@"E:\Degreed\csharp\Assignments\Assignment6\TextFiles\one.txt");
        
        public void fileRead()
        {
            Console.WriteLine(text);
        }
    }

    class FileInfo
    {
        public void fileInfo()
        {
            FileInfo fi = new FileInfo(@"E:\Degreed\csharp\Assignments\Assignment7\TextFiles\one.txt");
        }
    }

    public static void Main()
    {
        FileOperations.Files fileRead = new FileOperations.Files();

        fileRead.fileRead();
    }
}