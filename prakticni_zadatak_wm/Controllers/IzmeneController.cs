using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using AutoMapper;
using StorageServiceLibrary.Dto;
using System.IO;
using StorageServiceLibrary.Model;
using StorageServiceLibrary.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace prakticni_zadatak_wm.Controllers
{
    public class IzmeneController : Controller
    {
        private readonly App_Data_Base _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IzmeneController(IUnitOfWork unitOfWork, IMapper mapper, App_Data_Base context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var proizvodi = await _unitOfWork.Proizvodi.GetAll(null, null, new List<string> { "Kategorija", "Proizvodjac", "Dobavljac" });

            var results = _mapper.Map<List<ProizvodDTO>>(proizvodi);

            return View(results);


        }

        public async Task<IActionResult> AddOrEdit(int? proizvodId)
        {
            List<SelectListItem> kategorije = _context.Kategorije
                        .Select(k =>
                        new SelectListItem
                        {
                            Value = k.Id.ToString(),
                            Text = k.Naziv
                        }).ToList();

            ViewBag.KategorijeDDL = kategorije;

            List<SelectListItem> proizvodjaci = _context.Proizvodjaci
                   .Select(k =>
                   new SelectListItem
                   {
                       Value = k.Id.ToString(),
                       Text = k.Naziv
                   }).ToList();

            ViewBag.ProizvodjaciDDL = proizvodjaci;

            List<SelectListItem> dobavljaci = _context.Dobavljaci
                   .Select(k =>
                   new SelectListItem
                   {
                       Value = k.Id.ToString(),
                       Text = k.Naziv
                   }).ToList();

            ViewBag.DobavljaciDDL = dobavljaci;


            ViewBag.Naslov = proizvodId == null ? "Dodaj Novi Proizvod" : "Izmeni Proizvod";
            ViewBag.IsEdit = proizvodId == null ? false : true;
            if (proizvodId == null)
            {
                return View();
            }
            else
            {
                var proizvod = await _unitOfWork.Proizvodi.Get(q => q.Id == proizvodId);

                var result = _mapper.Map<ProizvodDTO>(proizvod);

                return View(result);
            }
        }

        //AddOrEdit Post Method
        [HttpPost]

        public async Task<IActionResult> AddOrEdit([FromForm] ProizvodDTO proizvod)
        {
            bool proizvodPostoji = false;

            var proveraProizvoda = await _context.Proizvodi.FindAsync(proizvod.Id);

            if (proveraProizvoda != null)
            {
                proizvodPostoji = true;
            }


            if (ModelState.IsValid)
            {
                try
                {
                    //update
                    if (proizvodPostoji)
                    {
                        _mapper.Map(proizvod, proveraProizvoda);
                        _unitOfWork.Proizvodi.Update(proveraProizvoda);
                        await _unitOfWork.Save();
                    }
                    else
                    {
                        //insert
                        var products = _mapper.Map<Proizvod>(proizvod);
                        await _unitOfWork.Proizvodi.Insert(products);
                        await _unitOfWork.Save();
                    }

                }
                catch (Exception ex)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}
