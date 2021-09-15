using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica_Nro2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_Nro2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ListaMascotas = GetMascotas();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Registro()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Registro(Usuario Usuario)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        // Creando Listado de Mascotas para los Cards
        public List<Mascota> GetMascotas()
        {
            List<Mascota> Mascotas = new List<Mascota>();

            Mascotas.Add(new Mascota { Raza = "Pastor Aleman", Tipo = "Perro", Descripcion= "El pastor alemán u ovejero es una raza canina que proviene de Alemania.", Foto= "https://upload.wikimedia.org/wikipedia/commons/9/94/Cane_da_pastore_tedesco_adulto.jpg" });
            Mascotas.Add(new Mascota { Raza = "Siamés", Tipo = "Gato", Descripcion = "El siamés moderno es una raza de gato proveniente del antiguo reino de Siam", Foto = "https://www.fanaticosdelasmascotas.cl/wp-content/uploads/2020/11/gatos_siames-siam%EF%BC%B4-liliy2025-Pixabay_portada.jpg" });
            Mascotas.Add(new Mascota { Raza = "Husky Siberiano", Tipo = "Perro", Descripcion = "El husky siberiano es una raza de perro de trabajo originaria del noreste de Siberia.", Foto = "https://www.animalfiel.com/wp-content/uploads/2020/07/tipos-de-husky-siberiano.png" });
                
            return Mascotas;
        }


    }
}
