using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRestaurant;

namespace WebRestaurant.Models
{
    public class ProduseBusiness
    {
        public AfisareProduse AfisareProduse { get; set; }
        public ProduseBusiness()
        {
            AfisareProduse = new AfisareProduse();
        }

        public Produs GetById(int id)
        {
            return this.AfisareProduse.Produse.Find(a => a.Id == id);
        }

        public List<Produs> Search(string criteria)
        {
            return this.AfisareProduse.Produse.Where(a =>
            a.Title.Contains(criteria) || a.Details.Contains(criteria)).ToList();
        }
    }
}
