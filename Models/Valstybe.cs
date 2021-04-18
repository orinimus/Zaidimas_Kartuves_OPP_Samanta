using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zaidimas_Kartuves_OPP_Samanta.Models
{
    public class Valstybe
    {
        [Key]
        public int ValstybeID { get; set; } //Kompozicija i valstybiu pavadinimus. Tol kol neturesim valstybiu Id, tol negalesim sukurti valstybiu pavadinimu ir kt. properciu
        public string Pavadinimas { get; set; }
        public int KiekSpeta { get; set; }
        public int KiekAtspeta { get; set; }
    }
}
