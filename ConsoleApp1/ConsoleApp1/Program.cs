namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime=Console.ReadLine();
            string prezme=Console.ReadLine();
            int godinaRođenja=int.Parse(Console.ReadLine());
            Student s = new Student(ime, prezme, godinaRođenja);
            s.Ocena = new List<int> { };
            Console.WriteLine("Unesi broj ocena");
            int broj=int.Parse(Console.ReadLine());
            for(int i=0; i<broj; i++)
            {
                Console.WriteLine("Unesi ocenu:");
                int ocena=int.Parse(Console.ReadLine());
                s.Ocena.Add(ocena);
                Console.WriteLine();
            }
            s.Ispis();
            s.IzracunajProsek();
            s.OdrediUspeh();
        }
    }
}
