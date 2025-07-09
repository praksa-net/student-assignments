using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Student
{
	public Student()
	{
		string Ime;
		string Prezime;
		int GodinaRodjenja;
		List<int> Ocene;

		double IzracunajProsek()
		{
			double suma = 0;
			foreach(int ocena in Ocene)
			{
				suma += ocena;
			}
			return suma / Ocene.Count;
		}

		void OdrediUspeh()
		{
			string prosek;
			double ocena = IzracunajProsek();
			if(ocena >= 4.5)
			{
				prosek = "Odlican.";
			}else if(ocena >= 3.5)
			{
				prosek = "Vrlo dobar.";
			}else if(ocena >= 2.5)
			{
				prosek = "Dobar.";
			}else if(ocena >= 1.5)
			{
				prosek = "Dovoljan.";
			}
			else
			{
				prosek = "Nedovoljan.";
			}
		}
	}
}
