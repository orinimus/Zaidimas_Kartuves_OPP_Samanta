using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.InitialData
{
    public class VardasInitialData // 10-ties vardu masyvas
    {
        public static Vardas[] DataSeed => new Vardas[] //grazins vardu sarasa, Vardas[] - masyvas
        {
            new Vardas { VardasID = 1, Pavadinimas = "Samanta"},
            new Vardas { VardasID = 2, Pavadinimas = "Marijus"},
            new Vardas { VardasID = 3, Pavadinimas = "Daiva"},
            new Vardas { VardasID = 4, Pavadinimas = "Greta"},
            new Vardas { VardasID = 5, Pavadinimas = "Rasita"},
            new Vardas { VardasID = 6, Pavadinimas = "Raminta"},
            new Vardas { VardasID = 7, Pavadinimas = "Nojus"},
            new Vardas { VardasID = 8, Pavadinimas = "Rasa"},
            new Vardas { VardasID = 9, Pavadinimas = "Martyna"},
            new Vardas { VardasID = 10, Pavadinimas = "Martynas"},
        };
    }
}
