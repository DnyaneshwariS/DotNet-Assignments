using System.IO;
using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\DNSURYAV\DotNet-Assignments\cSharp\Assigment 7";

            var dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("-----Displaying directories-----");
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.FullName}");
            }
            Console.WriteLine("\n-----Displaying all .txt files-----");
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} - { fileInfo.Length } bytes");
            }
        }
    }
}
