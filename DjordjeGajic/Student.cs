using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Student
{
	public Student()
	{
		string Ime { get; set; }
		string Prezime { get; set; }
		int GodinaRodjenja { get; set; }
		List<int> Ocene { get; set; }

		double IzracunajProsek()
		{
			double suma = 0;
			foreach(int ocena in Ocene)
			{
				suma += ocena;
			}
			return suma / Ocene.Count;
		}


	}
}
