using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.FileExists();
            Program.ReadAllLines();
            Program.ReadAllText();
            Program.FileCopy();
            Program.DeleteFile();
            ReadthroughStreamReader readstream = new ReadthroughStreamReader();
            readstream.WriteUsingStreamWriter();
            readstream.ReadFromStreamReader();
        }
        public static void FileExists()
        {
            String path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            Console.ReadKey();
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }
        
        public static void ReadAllText()
        {
            String path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
        public static void FileCopy()
        {
            string path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";
            string copypath = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\ExampleNew1.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\ExampleNew1.txt";

            File.Delete(path);

        }
    }
}
