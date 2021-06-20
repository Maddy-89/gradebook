using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Create a new Class called Book
    // Define a Method called AddGrade

    // What that means is how can i give the class the right members so other developers can understand what it si doing.
    // Add Members - What it can do
    // State, or data the class holds 
    // Behaviour Which acts on the state
    
    public class Book
    {
        // Create an explicit constructor to initialize grades
        // Method on the class
        // Add a constructor Parameter
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        // Instance Member
        public void AddGrade(double grade)
        {
            if  (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            } else {
                Console.Write("Invalid Value");
            }
        }
// Add statistics class identifier (return an object of type statistics)
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            // while loop is better than do while as it will not start if array is null
            // compared to Do While, will always execute atleast once
            while(index < grades.Count)
            {   
                result.Low = Math.Min(grades[index], result.Low); 
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index += 1;
            };
            //Compute an Average/highest/lowest for the number stored in the Grades List
            result.Average /= grades.Count;
            return result;

        }

        // State - Add a field - to access grades 
        private List<double> grades; 
        public string Name;
    }
}