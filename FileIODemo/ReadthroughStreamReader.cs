using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIODemo
{
    public class ReadthroughStreamReader
    {
        public void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public void ReadFromStreamReader()
        {
            String path = @"C:\Users\HP\csharp\FileIODemo\FileIODemo\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
