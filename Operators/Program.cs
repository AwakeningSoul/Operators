using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Create an Employee object with a different Id
            Employee emp3 = new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" };

            // Compare emp1 and emp2 using the overloaded == operator
            Console.WriteLine(emp1 == emp2); // Output: True

            // Compare emp1 and emp3 using the overloaded == operator
            Console.WriteLine(emp1 == emp3); // Output: False

            // Compare emp1 and emp2 using the overloaded != operator
            Console.WriteLine(emp1 != emp2); // Output: False

            // Compare emp1 and emp3 using the overloaded != operator
            Console.WriteLine(emp1 != emp3); // Output: True

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
