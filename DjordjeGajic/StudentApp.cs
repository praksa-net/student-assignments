using System;
using DjordjeGajic;
/// <summary>
/// Summary description for Class1
/// </summary>
public class StudentApp
{

	public StudentApp()
	{
        Console.WriteLine("Unesite ime studenta:");
        string ime;
        do
        {
            ime = Console.ReadLine();
        } while (!Validator.IsNameValid(ime));

        Console.WriteLine("Unesite prezime studenta:");
        string prezime;
        do
        {
            prezime = Console.ReadLine();
        }while(!Validator.IsNameValid(prezime));

        Console.WriteLine("Unesite godinu rodjenja:");
        int godinaRodjenja = UnosGodine.Unos();
        List<int> ocene = new List<int>();
        int unos = 1;
        do
        {
            unos = UnosOcene.Unos(ocene);
        } while (unos != 0);
        Student student = new Student(ime, prezime, godinaRodjenja, ocene);
    }

    
}