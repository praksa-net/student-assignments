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
            int ocena = Validator.Validacija();
            ocene.Add(ocena);
        } while (Console.ReadLine != 0);
        Student student = new Student("Djordje", "Gajic", 2007, ocene);
        student.PrikazInformacija();
    }

    
}