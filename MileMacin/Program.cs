class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Mile", "Macin", 2000);

        Console.Write("Unesite broj ocena: ");
        int brojOcena;
        while (!int.TryParse(Console.ReadLine(), out brojOcena) || brojOcena <= 0)
        {
            Console.Write("Molimo unesite ispravan pozitivan broj ocena: ");
        }

        for (int i = 0; i < brojOcena; i++)
        {
            Console.Write($"Unesite ocenu #{i + 1}: ");
            int ocena;
            while (!int.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 5)
            {
                Console.Write("Ocena mora biti ceo broj od 1 do 5. Pokusajte ponovo: ");
            }
            student.Ocene.Add(ocena);
        }

        double prosek = student.IzracunajProsek();
        Console.WriteLine($"Prosek ocena za {student.Ime} {student.Prezime} je: {prosek:F2}");

        Console.WriteLine($"Uspeh za {student.Ime} {student.Prezime} je: {student.OdrediUspeh()}");

        Console.WriteLine("Zdravo, MileMacin!");        
    }
}