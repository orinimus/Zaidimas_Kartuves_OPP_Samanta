using System;
using Zaidimas_Kartuves_OPP_Samanta.Database;
using Zaidimas_Kartuves_OPP_Samanta.Services;

namespace Zaidimas_Kartuves_OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new KartuvesContext())
            {
                KartuviuZaidimas.Kartuves(); //kartuviu zaidimo isvedimas i console ir database
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
