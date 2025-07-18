﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodinaRođenja { get; set; }
        public List<int> Ocena { get; set; }
        public Student(string ime,string prezime,int godinaRođenja) 
        {
            Ime = ime;
            Prezime = prezime;
            GodinaRođenja = godinaRođenja;
        }
        public void IzracunajProsek()
        {
            double prosek=Ocena.Average();
            Console.WriteLine(prosek);
        }
        public void OdrediUspeh()
        {
            double prosek = Ocena.Average();
            if(prosek < 1.5)
            {
                Console.WriteLine("Nedovoljan");
            }
            if (prosek < 2.5 && prosek > 1.5)
            {
                Console.WriteLine("dovoljan");
            }
            if(prosek > 2.5 && prosek < 3.5)
            {
                Console.WriteLine("Dobar");
            }
            if (prosek > 3.5 && prosek < 4.5)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else
            {
                Console.WriteLine("odličan");
            }
        }
        public void Ispis()
        {
            Console.WriteLine(Ime);
            Console.WriteLine(Prezime);
            Console.WriteLine(GodinaRođenja);
        }
    }
}
