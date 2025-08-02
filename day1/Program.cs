using System;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z;

            Console.WriteLine("Hello, C#");

            string name = typeof(Program).Namespace ?? "None!";

            Console.WriteLine($"Namespace: {name}");

            throw new Exception();
        }
    }
}
