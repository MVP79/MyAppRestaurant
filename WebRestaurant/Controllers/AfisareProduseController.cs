using Microsoft.AspNetCore.Mvc;
using WebRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebRestaurant.Controllers
{
    public class AfisareProduseController : Controller
    {
        public static AfisareProduse Home { get; set; }
        public static List<Produs> Cumparaturi = new List<Produs>();


        public IActionResult Index()
        {
            Home = new AfisareProduse();

            return View(Home.Produse);

        }
        public IActionResult Details(int id)
        {
            Home = new AfisareProduse();
            var found = Home.Produse.Find(a => a.Id == id);
            if (found != null)
            {
                return View(found);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult AdaugaInCos(int Id)
        {
            Home = new AfisareProduse();

            var found = Home.Produse.Find(a => a.Id == Id);
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


        public IActionResult ViewCumparaturi()
        {

            return View("Cumparaturi", Cumparaturi);

        }

        [HttpPost]
        public IActionResult Search(string criteria)
        {
            var filtered = Home.Produse.Where(a =>
            a.Title.Contains(criteria) || a.Details.Contains(criteria)).ToList();


            return View("Index", filtered);

        }


    }

}
