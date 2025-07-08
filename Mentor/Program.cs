class Program
{
    static void Main()
    {
        {
            hello();
        }

        static void hello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void variablesAndConstants()
        {
            string name = "Ana";
            int age = 20;
            const double Pi = 3.14159;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Pi: " + Pi);
        }

        static void overflowing()
        {
            byte b = 255;
            b += 1; // Overflow without checked context
            Console.WriteLine("Overflow result: " + b);
        }

        static void scope()
        {
            int x = 10;
            {
                int y = 20;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            // Console.WriteLine("y = " + y); // Error: y does not exist in this scope
        }

        static void typeConversion()
        {
            int a = 100;
            double b = a; // Implicit conversion
            int c = (int)b; // Explicit conversion

            Console.WriteLine("Double: " + b);
            Console.WriteLine("Back to int: " + c);
        }

        static void operators()
        {
            int a = 10, b = 5;
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
        }

        static void logicalOperators()
        {
            bool x = true, y = false;
            Console.WriteLine("AND: " + (x && y));
            Console.WriteLine("OR: " + (x || y));
            Console.WriteLine("NOT x: " + (!x));
        }
    }
}
