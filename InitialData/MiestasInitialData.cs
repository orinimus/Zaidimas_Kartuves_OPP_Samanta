using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.InitialData
{
    public class MiestasInitialData // 10-ties Lietuvos miestu pavadinimu masyvas
    {
        public static Miestas[] DataSeed => new Miestas[] //grazins miestu pavadinimu sarasa, Miestas[] - masyvas
        {
            new Miestas { MiestasID = 1, Pavadinimas = "Alytus"},
            new Miestas { MiestasID = 2, Pavadinimas = "Vilnius"},
            new Miestas { MiestasID = 3, Pavadinimas = "Kaunas"},
            new Miestas { MiestasID = 4, Pavadinimas = "Palanga"},
            new Miestas { MiestasID = 5, Pavadinimas = "Nida"},
            new Miestas { MiestasID = 6, Pavadinimas = "Druskininkai"},
            new Miestas { MiestasID = 7, Pavadinimas = "Plunge"},
            new Miestas { MiestasID = 8, Pavadinimas = "Birzai"},
            new Miestas { MiestasID = 9, Pavadinimas = "Marijampole"},
            new Miestas { MiestasID = 10, Pavadinimas = "Klaipeda"},
        };
    }
}
