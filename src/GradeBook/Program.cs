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
            // Example 1
            // Add Value to variable and use mathmatical operators
            // create 2 variable with type double - Type definition is explicit (double type is for float numbers)
            double x = 34.1;
            double y = 10.3;

            var result1 = x + y;
            Console.WriteLine(result1);

            // Example 2
            // create 2 variable using var type keyword - Type definition is not explicit, 
            // var automatically figures out type based on the context of what is happining.
            var a = 34.1;
            var b = 10.4;

            var result2 = a + b;
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
