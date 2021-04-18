using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zaidimas_Kartuves_OPP_Samanta.Models
{
    public class Spejimas
    {
        [Key]
        public int SpejimasID { get; set; } //Kompozicija i spejimus. Tol kol neturesim spejimu Id, tol negalesim sukurti kitu spejimu properciu
        public string ZaidejoVardas { get; set; }
        public string SpetasZodis { get; set; } //zaidejo spetas zodis is pasirinktos zodziu grupes - speto zodzio property
        public int KiekKartuSpejo { get; set; }
        public string Spejimai { get; set; } //kokias raides, zodzius spejo zaidejas
        public bool ArAtspejo { get; set; }
        public DateTime ZaidimoData { get; set; } //zaidimo datos property, bus naudojama now - atsispindes ta tada, kurios metu bus pradedama zaisti

    }
}
