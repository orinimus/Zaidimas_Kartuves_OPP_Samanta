using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zaidimas_Kartuves_OPP_Samanta.Models
{
    public class Ezeras
    {
        [Key]
        public int EzerasID { get; set; } //Kompozicija i Ezeru pavadinimus. Tol kol neturesim ezeru Id, tol negalesim sukurti ezeru pavadinimu ir kt. properciu
        public string Pavadinimas { get; set; } //ezeru pavadinimu property 
        public int KiekSpeta { get; set; } //ezeru pavadinimu spejimu property
        public int KiekAtspeta { get; set; } //kiek atspeta ezeru pavadinimu property
    }
}
