using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello " + args[0] + "!");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
