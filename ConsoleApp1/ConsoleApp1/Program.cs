namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Unesi kraj da bi se yavršio program");
                string unos=Console.ReadLine();
                if (unos.ToLower() == "kraj")
                {
                    break;
                }
                IspisStudenta.IspišiSve();
            }
        }
    }
}
