using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zaidimas_Kartuves_OPP_Samanta.Models
{
    public class Vardas
    {
        [Key]
        public int VardasID { get; set; } //Kompozicija i vardus. Tol kol neturesim vardu Id, tol negalesim sukurti vardu pavadinimu ir kt. properciu
        public string Pavadinimas { get; set; }
        public int KiekSpeta { get; set; }
        public int KiekAtspeta { get; set; }
    }
}
