using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.InitialData
{
    public class SpejimasInitialData // spejimu eiliskumo masyvas - 7, nes is viso septynis kartus galima speti zodi arba raide
    {
        public static Spejimas[] DataSeed => new Spejimas[] //grazins soejimu eiliskumo numeri, Spejimas[] - masyvas
        {
            new Spejimas { SpejimasID = 1 },
            new Spejimas { SpejimasID = 2 },
            new Spejimas { SpejimasID = 3 },
            new Spejimas { SpejimasID = 4 },
            new Spejimas { SpejimasID = 5 },
            new Spejimas { SpejimasID = 6 },
            new Spejimas { SpejimasID = 7 },

        };
    }
}
