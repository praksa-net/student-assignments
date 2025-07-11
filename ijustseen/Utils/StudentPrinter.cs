class StudentPrinter
{
  public StudentPrinter() { }

  public static void Prikazi(Student s)
    {
      Console.WriteLine($"Ime: {s.Ime}");
      Console.WriteLine($"Prezime: {s.Prezime}");
      Console.WriteLine($"Godina rođenja: {s.GodinaRodjenja}");
      Console.WriteLine($"Prosek ocena: {s.IzracunajProsek()}");
      Console.Write("Uspeh: ");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(s.OdrediUspeh());
      Console.ResetColor();
    }
}