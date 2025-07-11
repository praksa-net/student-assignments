using System;

public class Ispis_Studenata
{
	public void IspisiStudente(StudentApp studentApp)
	{

		double prosek = IzracunajProsek();
		string uspeh = OdrediUspeh();

        if (studentApp.studenti.Count == 0)
		{
			Console.WriteLine("Nema unetih studenata.");
			return;
		}
		foreach (var student in studentApp.studenti)
		{
			Console.WriteLine($"Ime: {student.Ime}, Prezime: {student.Prezime}, Godina Rodjenja: {student.GodinaRodjenja}");
			Console.WriteLine("Ocene: " + string.Join(", ", student.Ocene));
			Console.WriteLine();
		}
    }
}
