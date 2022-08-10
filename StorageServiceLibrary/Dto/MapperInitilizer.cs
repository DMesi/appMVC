using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageServiceLibrary.Model;
using AutoMapper;


namespace StorageServiceLibrary.Dto
{
    public class MapperInitilizer : Profile
    {

  //      Onda pozivam
  //      services.AddAutoMapper(typeof(MapperInitilizer));

        public MapperInitilizer()
        {
            CreateMap<Proizvod, ProizvodDTO>().ReverseMap();

        }
    }
}
