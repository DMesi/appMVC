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

        [Required(ErrorMessage = "Obavezno polje, unesite ime!")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obavezno polje, unesite opis!")]
        public string Opis { get; set; }

       
        [ForeignKey("Id_kategorija")]
        
        public Kategorija Kategorija { get; set; } 

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Obavezno polje, odaberite kategoriju!")]
        public int? Id_kategorija { get; set; }


        [ForeignKey("Id_Proizvodjac")]
        public Proizvodjac Proizvodjac { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Obavezno polje, odaberite proizvodjaca!")]
        public int Id_Proizvodjac { get; set; }

       
        [ForeignKey("Id_Dobavljac")]
        public Dobavljac Dobavljac { get; set; }
        
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Obavezno polje, odaberite dobavljaca!")]
        public int Id_Dobavljac { get; set; }

        [Required(ErrorMessage = "Obavezno polje, unesite cenu!")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Cena { get; set; }


    }
}
