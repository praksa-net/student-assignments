using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zdravo, DjordjeGajic!");
        List<int> ocene = new List<int>();
        do
        {
            Console.WriteLine("Unesite ocenu (ili '0' za kraj unosa.");
            int ocena = Validacija();
        } while (Console.ReadLine != 0);
        Student student = new Student("Djordje", "Gajic", 2007, )
    }

    static int Validacija()
    {
        while (true)
        {
            if(int.TryParse(Console.ReadLine(), out int rezultat))
            {
                if (rezultat > 0 && rezultat < 6)
                {
                    return rezultat;
                }
                else
                {
                    Console.WriteLine("Molimo Vas unesite validnu ocenu (od 1 do 5).");
                }
            }
            else
            {
                Console.WriteLine("Molimo Vas unesite BROJ od 1 do 5.");
            }
        }
    }
}