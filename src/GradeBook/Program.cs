﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a book variable from class Book - variable book refers to object of type Book
            var book = new Book("Maddy's grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.showStatistics();
        }
    }
}
