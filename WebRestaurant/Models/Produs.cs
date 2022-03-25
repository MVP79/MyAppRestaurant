using System;
using System.Collections.Generic;
using System.Text;

namespace WebRestaurant
{
    public class Alimente
    {
        public int Id { set; get; }
        public string Title { set; get; }
    }
    public class Produs:Alimente
    {
        
        
        public string Details { set; get; }
        public double Price { set; get; }
        public string ImageUrl { get; set; }

    }

}
