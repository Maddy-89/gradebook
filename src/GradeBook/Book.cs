using System.Collections.Generic;

namespace GradeBook
{
    // Create a new Class called Book
    // Define a Method called AddGrade

    // What that means is how can i give the class the right members so other developers can understand what it si doing.
    // Add Members - What it can do
    // State, or data the class holds 
    // Behaviour Which acts on the state
    
    class Book
    {
        // Create an explicit constructor to initialize grades
        // Method on the class
        // Add a constructor Parameter
        public Book(string name)
        {
            grades = new List<double>();
            // this.object - use when field has same name as parameter - explicit variable - on this object
            this.name = name;
        }
        // Instance Member
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        // State - Add a field - to access grades 
        private List<double> grades; 
        private string name;
    }
}