using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zaidimas_Kartuves_OPP_Samanta.Models
{
    public class Miestas
    {
        [Key]
        public int MiestasID { get; set; } //Kompozicija i miestu pavadinimus. Tol kol neturesim miestu Id, tol negalesim sukurti miestu pavadinimu ir kt. properciu
        public string Pavadinimas { get; set; } //miestu pavadinimu property 
        public int KiekSpeta { get; set; } //miestu pavadinimu spejimu property
        public int KiekAtspeta { get; set; } //kiek atspeta miestu pavadinimu property
    }
}
