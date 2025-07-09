using System;

class Program
{
    static void Main(string[] args)
    {
        Student ijustseen = new Student("Andrej", "Jerosenkov", 2007);
        Console.WriteLine("Unesite broj ocena studenta:");
        int brojOcena = int.Parse(Console.ReadLine());
        ijustseen.Ocene = new int[brojOcena];
        for (int i = 0; i < brojOcena; i++)
        {
            Console.Write($"Unesite {i + 1}. ocenu:");
            int ocena = int.Parse(Console.ReadLine());
            while (!Validator.ValidateOcena(ocena))
            {
                Console.WriteLine("Uneta ocena nije validna. Unesite ocenu između 1 i 5.");
                Console.Write($"Unesite {i + 1}. ocenu:");
                ocena = int.Parse(Console.ReadLine());
            }
            ijustseen.Ocene[i] = ocena;
        }

        Console.WriteLine($"Ime: {ijustseen.Ime}");
        Console.WriteLine($"Prezime: {ijustseen.Prezime}");
        Console.WriteLine($"Godina rođenja: {ijustseen.GodinaRodjenja}");
        Console.WriteLine($"Prosek ocena: {ijustseen.IzracunajProsek()}");

        Console.Write("Uspeh: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(ijustseen.OdrediUspeh());
        Console.ResetColor();

        /*
        Console.Write("What's your name? ");
        string Name = Console.ReadLine();
        Person ijustseen = new Person(Name, 18);

        {
            hello(ijustseen.Name);
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

        void hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        void variablesAndConstants()
        {
            string name = "Ana";
            int age = 20;
            const double Pi = 3.14159;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Pi: " + Pi);
        }

        void overflowing()
        {
            checked
            {
                byte b = 255;
                // b += 1; // Šta se dešava ovde?
            }
        }

        void scope()
        {
            int x = 10;
            {
                int y = 20;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            //Console.WriteLine("y = " + y);
        }

        void typeConversion()
        {
            int a = 100;
            double b = a;
            int c = (int)b;

            Console.WriteLine("Double: " + b);
            Console.WriteLine("Int: " + c);
        }

        void operators()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Sum: " + (a + b));
            Console.WriteLine("Sub: " + (a - b));
            Console.WriteLine("Multi: " + (a * b));
            Console.WriteLine("Div: " + (a / b));
            Console.WriteLine("Mod: " + (a % b));
        }

        void logicalOperators()
        {
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine("AND: " + (isTrue && isFalse));
            Console.WriteLine("OR: " + (isTrue || isFalse));
            Console.WriteLine("NOT: " + (!isTrue));
        }

        void ifExample()
        {
            int x = int.Parse(Console.ReadLine());
            if (x > 5) Console.WriteLine("x is greater than 5");
        }

        void ifElseExample()
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) Console.WriteLine("thats 0");
            else if (x % 2 == 0) Console.WriteLine("Paran broj");
            else Console.WriteLine("Neparan broj");
        }

        void switchExample()
        {
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("it's monday");
                    break;
                case 2:
                    Console.WriteLine("it's tuesday");
                    break;
                case 3:
                    Console.WriteLine("it's wednesday");
                    break;
                case 4:
                    Console.WriteLine("it's thursday");
                    break;
                case 5:
                    Console.WriteLine("it's friday");
                    break;
                case 6:
                    Console.WriteLine("it's saturday");
                    break;
                case 7:
                    Console.WriteLine("it's sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        static void whileLoopExample()
        {
            int text = 0;
            while (text != 3)
            {
                Console.WriteLine("Count is: " + count);
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
        */
    }
}