using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageServiceLibrary.Model
{
   public class App_Data_Base : DbContext
    {

        public App_Data_Base(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Dobavljac> Dobavljaci { get; set; }
        public DbSet<Proizvodjac> Proizvodjaci { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Proizvod>().HasData(
            new Proizvod
            {
                Id = 1,
                Naziv = "DELL Monitor 24",
                Opis = "EAN:5397184409336 <br/> Dijagonala:23.8'' <br/>Tip panela:IPS <br/>Rezolucija:1920 x 1080 Full HD <br/>Vreme odziva:4ms <br/>Odnos stranica:16 : 9 <br/>Osvežavanje:75Hz ...",
                Id_kategorija = 1,
                Id_Proizvodjac = 1,
                Id_Dobavljac = 2,
                Cena = 21999
            },
             new Proizvod
             {
                 Id = 2,
                 Naziv = "ASUS Kućište ROG Z11",
                 Opis = "EAN:4718017759526 <br/>Tip:Mini Tower <br/>Kompatibilnost:Mini-ITX, Mini-DTX <br/>Napajanje:Bez napajanja <br/>Boja:Crna",
                 Id_kategorija = 2,
                 Id_Proizvodjac = 2,
                 Id_Dobavljac = 2,
                 Cena = 20999
             },
             new Proizvod
             {
                 Id = 3,
                 Naziv = "DELL Vostro5625 - NOT19638",
                 Opis = "EAN:5290322196382 <br/>Model procesora:AMD Ryzen 7 5825U do 4.5GHz  <br/>Dijagonala ekrana:16''  <br/>Tip grafičke karte:Integrisana Radeon™ RX Vega 8  <br/>RAM (memorija):16GB  <br/>HDD SSD:512GB SSD",
                 Id_kategorija = 3,
                 Id_Proizvodjac = 1,
                 Id_Dobavljac = 1,
                 Cena = 159999
             }

            );


          builder.Entity<Kategorija>().HasData(
          new Kategorija
          {
              Id = 1,
              Naziv = "MONITOR",

          },
          new Kategorija
          {
               Id = 2,
               Naziv = "KUCISTE",

          },
           new Kategorija
           {
               Id = 3,
               Naziv = "LAPTOP",

           }
          );

            builder.Entity<Proizvodjac>().HasData(
            new Proizvodjac
            {
                Id = 1,
                Naziv = "DELL",
                Adresa = "Ime ulice BB",
                BrojTelefona = "123456789"

            },
             new Proizvodjac
             {
                 Id = 2,
                 Naziv = "ASUS",
                 Adresa = "Ime ulice BB",
                 BrojTelefona = "123456789"

             }
      );

            builder.Entity<Dobavljac>().HasData(
            new Dobavljac
            {
                Id = 1,
                Naziv = "ACME",
                Adresa = "Ime ulice BB",
                BrojTelefona = "827352"

            },

             new Dobavljac
             {
                 Id = 2,
                 Naziv = "GIGATRON",
                 Adresa = "Ime ulice BB",
                 BrojTelefona = "827352"

             }
            ) ;
        }




        }
}
