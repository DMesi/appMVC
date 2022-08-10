using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageServiceLibrary.IRepository;
using StorageServiceLibrary.Model;
using AutoMapper;
using StorageServiceLibrary.Dto;
using System.IO;
using System.Text.Json;
using prakticni_zadatak_wm.Models;


namespace prakticni_zadatak_wm.Controllers
{
    public class ProizvodController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProizvodController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {

            var proizvodi = await _unitOfWork.Proizvodi.GetAll(null, null, new List<string> { "Kategorija", "Proizvodjac", "Dobavljac" });

            var results = _mapper.Map<List<ProizvodDTO>>(proizvodi);

            return View(results);

        }
        public IActionResult PrikaziJSON()
        {

            List<ProizvodJSON> proizvodi = new List<ProizvodJSON>();

            using (StreamReader r = new StreamReader("Models/data.json"))
            {
                string json = r.ReadToEnd();
                proizvodi = JsonSerializer.Deserialize<List<ProizvodJSON>>(json);
            }

            return View(proizvodi);
        }
    }
}
