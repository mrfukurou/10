using System;
using System.IO;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");
            Console.WriteLine("Папки были успешно созданы!");
        }
    }
}
