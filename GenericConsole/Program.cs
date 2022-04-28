using System;
using System.Reflection;

namespace GenericConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine("OK!");
            Int32.TryParse(input, out int num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
            }

            // Using GetType to obtain type information:
            int j = 42;
            Type type = j.GetType();
            Console.WriteLine(type);

            // Using Reflection to get information of an Assembly:
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
        }
    }
}
