using System;
using System.Collections.Generic;

namespace Gradebook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Paddy's Gradebook");
            book.AddGrade(10.0);
            book.AddGrade(44.0);
            book.AddGrade(46.0);
            book.ShowStatistics();

            
        }
    }
}
