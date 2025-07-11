class StudentFactory
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
    // Create a mock student with predefined values
    Student mockStudent = new Student("Andrej", "Jerosenkov", 2007);

    return mockStudent;
  }

  public static Student CreateStudent()
  {
    // Create a student with provided values
    Console.Write("Unesite ime studenta: ");
    string name = Console.ReadLine();
    Console.Write("Unesite prezime studenta: ");
    string surname = Console.ReadLine();
    Console.Write("Unesite godinu rođenja studenta: ");
    int yearOfBirth = Validator.validateIntLine();

    Student student = new Student(name, surname, yearOfBirth);

    return student;
  }

  public void initClass()
  {
    Student mockStudent = CreateMockStudent();
    mockStudent.UnosOcena();
    AddStudent(mockStudent);
    Console.WriteLine(mockStudent.Ime + " " + mockStudent.Prezime + " je uspešno dodat u listu studenata.");
  }
}