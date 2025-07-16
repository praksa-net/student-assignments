using Xunit;

public class StudentFactoryTests
{
    [Fact]
    public void AddStudent_AddsStudentToList()
    {
        var factory = new StudentFactory();
        var student = new Student();
        factory.AddStudent(student);
        Assert.Contains(student, factory.GetAllStudents());
    }

    [Fact]
    public void CreateMockStudent_ReturnsExpectedStudent()
    {
        var student = StudentFactory.CreateMockStudent();
        Assert.Equal("Andrej", student.Ime);
        Assert.Equal("Jerosenkov", student.Prezime);
        Assert.Equal(2007, student.GodinaRodjenja);
        Assert.Equal(new int[] { 5, 4, 5, 5, 4 }, student.Ocene);
    }
} 