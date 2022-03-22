using System;
using System.Collections.Generic;
using System.Text;
using Restaurant;

namespace Restaurant
{
    public class AfisareProduse
    {
        public List<Produs> Produse { get; set; }


        public AfisareProduse()
        {
            Produse = new List<Produs>();


            Produse.Add(new Produs
            {
                Id = 1,
                Title = "Ciorba de pui",
                Details = "carne de pui, diverse legume, cartofi",
                Price = 12,
                ImageUrl = "https://d1lqpgkqcok0l.cloudfront.net/site/binaries/_ht_1588072271000/lg/content/gallery/image-components/mega-image-romania-ro/articol-retete-ciorba-pui/cmsitem_00013710.jpg"
            });
            Produse.Add(new Produs
            {
                Id = 2,
                Title = "Ciorba de porc",
                Details = "carne de porc, diverse legume",
                Price = 14,
                ImageUrl = "https://d1lqpgkqcok0l.cloudfront.net/site/binaries/_ht_1588072271000/lg/content/gallery/image-components/mega-image-romania-ro/articol-retete-ciorba-pui/cmsitem_00013711.jpg"
            });
            Produse.Add(new Produs
            {
                Id = 3,
                Title = "Ciorba de curcan",
                Details = "carne de curcan, diverse legume",
                Price = 16,
                ImageUrl = "https://d1lqpgkqcok0l.cloudfront.net/site/binaries/_ht_1588072271000/lg/content/gallery/image-components/mega-image-romania-ro/articol-retete-ciorba-pui/cmsitem_00013763.jpg"
            });
            Produse.Add(new Produs
            {
                Id = 4,
                Title = "Burger de vita",
                Details = "carne de vita, salata, ceapa, cascaval",
                Price = 34,
                ImageUrl = "https://savoriurbane.com/wp-content/uploads/2017/06/Burger-de-vita-cu-branza-reteta-de-cheeseburger-de-casa-savori-urbane.jpg"
            });
            Produse.Add(new Produs
            {
                Id = 5,
                Title = "Burger vegetarian",
                Details = "naut, salata, ceapa, andiva",
                Price = 38,
                ImageUrl = "https://thesmartcuisine.com/wp-content/uploads/2016/02/IMG_3615-2-1024x683.jpg"
            });
            Produse.Add(new Produs
            {
                Id = 6,
                Title = "Tort bezea",
                Details = "bezea, fructe, caramel",
                Price = 160,
                ImageUrl = "https://static.wixstatic.com/media/db40f4_a01eef769b7a4f3dbacd083123afe40f~mv2.jpg/v1/fill/w_554,h_554,al_c,q_85,usm_0.66_1.00_0.01/db40f4_a01eef769b7a4f3dbacd083123afe40f~mv2.jpg"
            });



        }
    }
}