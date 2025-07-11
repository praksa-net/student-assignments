using System;
using System.Collections.Generic;

class Student
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int GodinaRodjenja { get; set; }
    public List<int> Ocene { get; set; }

    public Student(string ime, string prezime, int godinaRodjenja)
    {
        Ime = ime;
        Prezime = prezime;
        GodinaRodjenja = godinaRodjenja;
        Ocene = new List<int>();
    }


    

    
}
