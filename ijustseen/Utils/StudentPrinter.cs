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

  public static void CountStudents(StudentFactory studentFactory)
  {
    List<Student> students = studentFactory.Students;
    Console.WriteLine($"Broj studenata: {students.Count}");
    if (students.Count > 0)
    {
      Console.WriteLine("Prvi student:");
      Prikazi(students[0]);
    }
    else
    {
      Console.WriteLine("Nema studenata.");
    }
  }
}