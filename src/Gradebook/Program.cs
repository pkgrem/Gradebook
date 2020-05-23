using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {    
            var book = new Book("Paddy's Gradebook");
            book.AddGrade(10.0);
            book.AddGrade(44.0);
            book.AddGrade(46.0);
 
            var stats = book.GetStatistics();         
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");            
        }        
    }
}
