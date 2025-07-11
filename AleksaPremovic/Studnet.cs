using System;
using System.Collections.Generic;

public class Student
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int GodinaRodjenja { get; set; }
    public List<int> Ocene { get; set; }

    public Student()
    {
        Ocene = new List<int>();
    }
}
