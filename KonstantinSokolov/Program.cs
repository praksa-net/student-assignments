using KonstantinSokolov.Models;
using KonstantinSokolov.Services;
using KonstantinSokolov.Services.Printers;
using System;
using static KonstantinSokolov.Services.StudentApp;

namespace KonstantinSokolov
{
    class Program
    {
        static void Main(string[] args)
        {
            var consolePrinter = new StudentConsolePrinter();
            StudentApp.Run(printer: consolePrinter, useMocks: false);
        }
    }

    

}
