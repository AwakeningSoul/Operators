using System;

namespace Operators
{
    // Define the Employee class
    public class Employee
    {
        // Properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by their Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Check if the first object is null
            if (ReferenceEquals(e1, null))
            {
                // If the first object is null, check if the second object is also null
                return ReferenceEquals(e2, null);
            }

            // Compare the Ids of both Employee objects
            return e1.Id == e2.Id;
        }

        // Overload the != operator to compare two Employee objects by their Id
        public static bool operator !=(Employee e1, Employee e2)
        {
            // Use the overloaded == operator to check if they are not equal
            return !(e1 == e2);
        }

        // Override the Equals method to provide a custom equality comparison
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee otherEmployee)
            {
                // Compare the Ids
                return Id == otherEmployee.Id;
            }

            return false;
        }

        // Override the GetHashCode method to ensure consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}