using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.InitialData
{
    public class ValstybeInitialData // 10-ties valstybiu pavadinimu masyvas
    {
        public static Valstybe[] DataSeed => new Valstybe[] //grazins valstybiu pavadinimu sarasa, Valstybe[] - masyvas
        {
            new Valstybe { ValstybeID = 1, Pavadinimas = "Lietuva"},
            new Valstybe { ValstybeID = 2, Pavadinimas = "Vokietija"},
            new Valstybe { ValstybeID = 3, Pavadinimas = "Airija"},
            new Valstybe { ValstybeID = 4, Pavadinimas = "Anglija"},
            new Valstybe { ValstybeID = 5, Pavadinimas = "Danija"},
            new Valstybe { ValstybeID = 6, Pavadinimas = "Egiptas"},
            new Valstybe { ValstybeID = 7, Pavadinimas = "Italija"},
            new Valstybe { ValstybeID = 8, Pavadinimas = "Rusija"},
            new Valstybe { ValstybeID = 9, Pavadinimas = "Turkija"},
            new Valstybe { ValstybeID = 10, Pavadinimas = "Graikija"},
        };
    }
}
