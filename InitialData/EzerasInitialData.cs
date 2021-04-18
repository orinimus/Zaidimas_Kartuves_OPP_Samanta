using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.InitialData
{
    public class EzerasInitialData // 10-ties Lietuvos ezeru pavadinimu masyvas
    {
        public static Ezeras[] DataSeed => new Ezeras[] //grazins ezeru pavadinimu sarasa, Ezeras[] - masyvas
        {
            new Ezeras { EzerasID = 1, Pavadinimas = "Purvis"},
            new Ezeras { EzerasID = 2, Pavadinimas = "Dauniskis"},
            new Ezeras { EzerasID = 3, Pavadinimas = "Alausis"},
            new Ezeras { EzerasID = 4, Pavadinimas = "Tauragnas"},
            new Ezeras { EzerasID = 5, Pavadinimas = "Obelija"},
            new Ezeras { EzerasID = 6, Pavadinimas = "Asveja"},
            new Ezeras { EzerasID = 7, Pavadinimas = "Metelys"},
            new Ezeras { EzerasID = 8, Pavadinimas = "Giedavardys"},
            new Ezeras { EzerasID = 9, Pavadinimas = "Dviragis"},
            new Ezeras { EzerasID = 10, Pavadinimas = "Dusia"},
        };
    }
}
