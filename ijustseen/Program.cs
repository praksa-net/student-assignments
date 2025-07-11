using System;

class Program
{
    static void Main(string[] args)
    {

        StudentFactory studentFactory = new StudentFactory();
        studentFactory.initClass();

        StudentPrinter.Prikazi(studentFactory.Students[0]);
    }
}