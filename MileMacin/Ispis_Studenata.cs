using System;

public class Ispis_Studenata
{
	public void IspisiStudente(StudentApp studentApp)
	{


        if (studentApp.studenti.Count == 0)
		{
			Console.WriteLine("Nema unetih studenata.");
			return;
		}
		foreach (var student in studentApp.studenti)
		{
            double prosek = student.IzracunajProsek();
            string uspeh = student.OdrediUspeh();

            Console.WriteLine($"Ime: {student.Ime}, Prezime: {student.Prezime}, Godina Rodjenja: {student.GodinaRodjenja}");
			Console.WriteLine("Ocene: " + string.Join(", ", student.Ocene));
			Console.WriteLine($"Prosek: {prosek:F2}");
			Console.WriteLine($"Uspeh: {uspeh}");
			Console.WriteLine();
		}
    }
}
