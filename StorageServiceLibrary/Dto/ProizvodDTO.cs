using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StorageServiceLibrary.Model;

namespace StorageServiceLibrary.Dto
{
  public  class ProizvodDTO
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }


        [ForeignKey("Id_kategorija")]
        public Kategorija Kategorija { get; set; }  //ovo moze include
        public int Id_kategorija { get; set; }


        [ForeignKey("Id_Proizvodjac")]
        public Proizvodjac Proizvodjac { get; set; }//ovo moze include
        public int Id_Proizvodjac { get; set; }

        //  [ForeignKey(nameof(Dobavljac))]
        [ForeignKey("Id_Dobavljac")]
        public Dobavljac Dobavljac { get; set; }//ovo moze include
        public int Id_Dobavljac { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Cena { get; set; }


        //public virtual IList<Kategorija> LKategorije { get; set; }//ovo moze include
        //public virtual IList<Dobavljac> LDobavljaci { get; set; }//ovo moze include
        //public virtual IList<Proizvodjac> LProizvodjaci { get; set; }//ovo moze include
    }
}
