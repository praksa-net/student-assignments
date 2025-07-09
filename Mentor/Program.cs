class Program
{
    static void Main()
    {
        hello();
        variablesAndConstants();
        overflowing();
        scope();
        typeConversion();
        operators();
        logicalOperators();
        ifExample();
        ifElseExample();
        switchExample();
        whileLoopExample();
        forLoopExample();
        foreachLoopExample();
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

    static void ifExample()
    {
        int number = 7;
        if (number > 5)
        {
            Console.WriteLine("Number is greater than 5");
        }
    }

    static void ifElseExample()
    {
        int number = 3;
        if (number % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }

    static void switchExample()
    {
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Another day");
                break;
        }
    }

    static void whileLoopExample()
    {
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("Count is: " + count);
            count++;
        }
    }

    static void forLoopExample()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }
    }

    static void foreachLoopExample()
    {
        string[] colors = { "red", "green", "blue" };
        foreach (string color in colors)
        {
            Console.WriteLine("Color: " + color);
        }
    }
}
