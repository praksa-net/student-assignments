class Program
{
    static void Main(string[] args)
    {
        

        double prosek = student.IzracunajProsek();
        Console.WriteLine($"Prosek ocena za {student.Ime} {student.Prezime} je: {prosek:F2}");

        Console.WriteLine($"Uspeh za {student.Ime} {student.Prezime} je: {student.OdrediUspeh()}");

        Console.WriteLine("Zdravo, MileMacin!");        
    }
}