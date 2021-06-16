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
            grades.Add(grade);
        }
// Add statistics class identifier (return an object of type statistics)
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {   
                result.Low = Math.Min(grade, result.Low); 
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            //Compute an Average/highest/lowest for the number stored in the Grades List
            result.Average /= grades.Count;
            return result;

        }

        // State - Add a field - to access grades 
        private List<double> grades; 
        public string Name;
    }
}