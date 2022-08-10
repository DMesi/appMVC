using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageServiceLibrary.Model
{
   public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        //public List<Proizvod> Proizvodi { get; set; }
    }
}
