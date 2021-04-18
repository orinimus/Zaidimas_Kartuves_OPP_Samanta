using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.Database
{
    public class ManageKartuvesDB
    {
        private readonly KartuvesContext context;

        public ManageKartuvesDB(KartuvesContext context)
        {
            this.context = context;
        }

        public List<Ezeras> GetAllEzerus()
        {
            return context.Ezerai.Include(p => p.Pavadinimas).ToList();
        } //gauti visus ezerus metodas

        public List<Miestas> GetAllMiestai()
        {
            return context.Miestai.Include(p => p.Pavadinimas).ToList();
        } //gauti visus miestus metodas

        public List<Valstybe> GetAllValstybes()
        {
            return context.Valstybes.Include(p => p.Pavadinimas).ToList();
        } //gauti visus miestus metodas

        public List<Vardas> GetAllVardus()
        {
            return context.Vardai.Include(p => p.Pavadinimas).ToList();
        } //gauti visus vardus metodas
        public List<Spejimas> GetAllSpejimus()
        {
            return context.Spejimai.Include(p => p.SpejimasID).ToList();
        } //gauti visus spejimus metodas


        public void Ezeras(string pavadinimas)
        {
            using (var context = new KartuvesContext())
            {
                context.Database.EnsureCreated();
                context.Ezerai.Add(new Models.Ezeras { Pavadinimas = pavadinimas });
                context.SaveChanges();
            }
        }

        public void Miestas(string pavadinimas)
        {
            using (var context = new KartuvesContext())
            {
                context.Database.EnsureCreated();
                context.Miestai.Add(new Models.Miestas { Pavadinimas = pavadinimas });
                context.SaveChanges();
            }
        }
        public void Valstybe(string pavadinimas)
        {
            using (var context = new KartuvesContext())
            {
                context.Database.EnsureCreated();
                context.Valstybes.Add(new Models.Valstybe { Pavadinimas = pavadinimas });
                context.SaveChanges();
            }
        }
        public void Vardas(string pavadinimas)
        {
            using (var context = new KartuvesContext())
            {
                context.Database.EnsureCreated();
                context.Vardai.Add(new Models.Vardas { Pavadinimas = pavadinimas });
                context.SaveChanges();
            }
        }
    }
}
