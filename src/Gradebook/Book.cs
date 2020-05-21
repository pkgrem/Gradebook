using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // this is required due to the names being the same for the object and reference.
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var grade = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var avgGrade = double.MinValue;
            foreach(var number in grades) 
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                grade += number;

                avgGrade = grade / grades.Count;
            }
            // grade is adding each digit and creating a grade value

            var sum = grades.Count; 
            var average = grade / sum;

            System.Console.WriteLine(grade);
            System.Console.WriteLine(sum);
            System.Console.WriteLine($"The highest grade is {highGrade:N2}");
            System.Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            System.Console.WriteLine($"The average grade is {avgGrade:N2}");

        }

        private List<double> grades;
            private string name;

    }
}