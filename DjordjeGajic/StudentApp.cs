using System;
using DjordjeGajic;
/// <summary>
/// Summary description for Class1
/// </summary>
public class StudentApp
{

	public StudentApp()
	{
        List<int> ocene = new List<int>();
        int unos = 1;
        do
        {
            unos = UnosOcene.Unos(ocene);
        } while (unos != 0);
        Student student = new Student("Djordje", "Gajic", 2007, ocene);
    }
}
