using Microsoft.AspNetCore.Mvc;
using WebRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant.Models;


namespace WebRestaurant.Controllers
{
    public class AfisareProduseController : Controller
    {
        public static ProduseBusiness _produse { get; set; }
      
        public static List<Produs> Cumparaturi = new List<Produs>();


        public IActionResult Index()
        {
            _produse = new ProduseBusiness();
            return View(_produse.AfisareProduse.Produse);

        }
        public IActionResult Details(int id)
        {
            
            var found = _produse.GetById(id);
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult AdaugaInCos(int id)
        {


           var found = _produse.GetById( id);
            if (found != null)
            {
                Cumparaturi.Add(found);


            }

            return RedirectToAction("ViewCumparaturi");
        }

        public IActionResult Stergere(int id)
        {
            var foundCumparaturi = Cumparaturi.Find(a => a.Id == id);
            if (foundCumparaturi != null)
            {
                Cumparaturi.Remove(foundCumparaturi);
            }

            return RedirectToAction("ViewCumparaturi");
        }
       
        public IActionResult ListByPrice()
        {
            var ordered = _produse.ListByPrice();
            return View("Index", ordered);
        }


        public IActionResult ViewCumparaturi()
        {

            return View("Cumparaturi", Cumparaturi);

        }

        [HttpPost]
        public IActionResult Search(string criteria)
        {
            var filtered = _produse.Search(criteria);


            return View("Index", filtered);

        }


    }

}
