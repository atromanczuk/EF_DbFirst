using DbFirst.Data.EF;
using DbFirst.Servicios.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DbFirst.Web.Controllers
{
    public class AnimalController : Controller
    {
        ITipoAnimalServicio _tipoAnimalServicio;
        IAnimalServicio _animalServicio;

        //para vivir necesito un servicio
        public AnimalController(ITipoAnimalServicio tipoAnimalServicio, IAnimalServicio animalServicio)
        {
            _tipoAnimalServicio = tipoAnimalServicio;
            _animalServicio = animalServicio;
        }

        [HttpGet]
        public ActionResult Alta()
        {
            ViewBag.TipoAnimales = _tipoAnimalServicio.ObtenerTodos();    
            return View();
        }


        [HttpPost]
        public ActionResult Alta(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                //List<TipoAnimal> tipoAnimales = _tipoAnimalServicio.ObtenerTodos();
                //ViewBag.TipoAnimales = tipoAnimales;
                ViewBag.TipoAnimales = _tipoAnimalServicio.ObtenerTodos();
                return View(animal);
            }
            _animalServicio.Insertar(animal);

            return RedirectToAction("Listar");
        }


        // GET: AnimalController
        public ActionResult Index() 
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_animalServicio.ObtenerTodos());
        }



    }
}
