using System;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IspisStudenta i = new IspisStudenta();
            while (true)
            {
                Console.WriteLine("Unesi kraj da bi se yavršio program");
                string unos = Console.ReadLine();
                if (unos.ToLower() == "kraj")
                {
                    break;
                }
                i.IspišiSve();
            }
        }
    }
}
