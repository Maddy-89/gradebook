using System;

namespace GradeBook
{
    class Program
    {
        // A Method Named Main
        // Main has a Parameter called args with type string array
        // array is a collection of objects
        static void Main(string[] args)
        {
            // Exercise 1
            // Initialise a new array that can hold 3 numbers
            double[]numbers = new double[3];
            // Add 3 number to each position in the array - Individual statememnts
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;
            // Add each number in the array and write the result
            var result = numbers[0];
            result = result + numbers [1];
            result = result + numbers [2];
            Console.WriteLine(result);

            // Exercise 2 - Simplify the above code
            // Initialise a new array that can hold 3 numbers and add number to the array (array initialization syntax)
            var numbers2 = new [] { 12.7, 10.3, 6.11, 4.1};
            
            //add a foreach loop statement to iterate through all numbers in the array and add them to the result variable
            var result2 = 0.0;
            foreach (double number2 in numbers2)
            {
            result2 += number2;
            }
            Console.WriteLine(result2);

            // An If statement to check that the args array is not empty - Error Handling
            if (args.Length > 0) 
            {
                // String Concatonation
                Console.WriteLine("Hello " + args[0] + "!");
                // String Interpulation
                Console.WriteLine($"Hello, {args[0]} !");
            } else {
                Console.WriteLine("Hello");
            }
        }
    }
}
