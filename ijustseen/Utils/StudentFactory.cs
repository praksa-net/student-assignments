using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class StudentFactory
{
  public List<Student> Students { get; set; }

  public StudentFactory()
  {
    Students = new List<Student>();
  }

  public void AddStudent(Student student)
  {
    if (student != null)
    {
      Students.Add(student);
    }
  }

  public static Student CreateMockStudent()
  {
    Student mockStudent = new Student("Andrej", "Jerosenkov", 2007);
    mockStudent.Ocene = new int[] { 5, 4, 5, 5, 4 };
    return mockStudent;
  }

  public static Student CreateStudent()
  {
    Console.Write("Unesite ime studenta: ");
    string name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name) || name == "kraj")
    {
      return null;
    }

    Console.Write("Unesite prezime studenta: ");
    string surname = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(surname) || surname == "kraj")
    {
      return null;
    }
    Console.Write("Unesite godinu rođenja studenta: ");
    int yearOfBirth = Validator.UnesiDatum();

    Student student = new Student(name, surname, yearOfBirth);

    return student;
  }

  public void initClass()
  {

    // Student mockStudent = CreateMockStudent();
    // mockStudent.UnosOcena();
    // AddStudent(mockStudent);
    inputStudents();
  }

  public void inputStudents()
  {
    while (true)
    {
      Student student = CreateStudent();
      if (student == null)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Kraj unosa.");
        Console.ResetColor();
        Console.WriteLine();
        break;
      }
      student.UnosOcena();
      Console.WriteLine();
      AddStudent(student);
    }
  }

  public List<Student> GetAllStudents()
  {
    return Students;
  }

  public void AddMockStudent()
  {
    AddStudent(CreateMockStudent());
  }

  public void SaveToJsonFile(string filePath = "studenti.json")
  {
    var options = new JsonSerializerOptions { WriteIndented = true };
    options.Converters.Add(new JsonStringEnumConverter());
    string json = JsonSerializer.Serialize(Students, options);
    File.WriteAllText(filePath, json);
    Console.WriteLine($"--Studenti su sačuvani u fajl: {filePath}--");
    Console.WriteLine();
  }
}