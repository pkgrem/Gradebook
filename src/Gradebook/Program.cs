using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12,34,3,12,5,2,33,44,12,5}; // this declares the variable and defines the amount of values within it. 
            //numbers[0] = 12.7;
            //numbers[1] = 11.7;
            //numbers[2] = 10.7;

            //var result = numbers[0] + numbers[1] + numbers[2];
            //result += numbers[3];

            List<double> grades = new List<double>() {12,34,3,12,5,2,33,44,12,5};
            grades.Add(12);

            var result = 0.0;
            foreach(var number in numbers) 
            {
                result += number;
            }

            var grade = 0.0;
            foreach(var digit in grades) 
            {
                grade += digit;
            }

            var sum = grades.Count; 
            var average = grade / sum;

            //Console.WriteLine("Hello " + args[0] + "!");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }

            System.Console.WriteLine(result);
            System.Console.WriteLine(grade);
            System.Console.WriteLine(sum);
            System.Console.WriteLine($"The average grade is {average:N2}");

        }
    }
}
