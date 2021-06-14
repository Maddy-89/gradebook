using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // A Method Named Main
        // Main has a Parameter called args with type string array
        // array is a collection of objects
        static void Main(string[] args)
        {
            // initialize a list called grades of type double for foating point numbers
            // List<double> grades = new List<double>() ;

            // initialize an Implicit List
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1}; 

            // Add value to list
            grades.Add(56.1);

            // Index into the list to see the first value
            // grades[0];

            //add a foreach loop statement to iterate through all numbers in the list and add them to the result variable
            var result = 0.0;
            foreach (var number in grades)
            {
            result += number;
            }
            //Compute an Average for the number stored in the Grades List
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
