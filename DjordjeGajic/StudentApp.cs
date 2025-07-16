using DjordjeGajic;
using System;
using System.Text.Json;
/// <summary>
/// Summary description for Class1
/// </summary>
public class StudentApp
{
    List<Student> students;

	public StudentApp()
	{
        students = Json.Get();
        do
        {
            AddStudent();
            Console.WriteLine("Student uspesno dodat u listu.");
            Console.WriteLine("Da li zelite da nastavite sa unosom studenata? Ukoliko ne, unesite 'kraj'.");
        } while (Console.ReadLine().ToLower() != "kraj");
        Console.WriteLine("Studenti uspesno sacuvani.");
        Json.Save(students);
    }

    public void AddStudent()
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
        } while (!Validator.IsNameValid(prezime));

        int godinaRodjenja = UnosGodine.Unos();

        List<int> ocene = new List<int>();
        int unos;
        do
        {
            unos = UnosOcene.Unos(ocene);
        } while (unos != 0);

        Student student = new Student(ime, prezime, godinaRodjenja, ocene);
        students.Add(student);
        
    }
    
    
}