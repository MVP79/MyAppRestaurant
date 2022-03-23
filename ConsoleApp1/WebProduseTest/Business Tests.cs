using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebRestaurant.Models;
using System.Linq;
namespace WebProduseTest
{
    [TestClass]
    public class BusinessTests
    {
        [TestMethod]
        public void Search()
        {
            string c = "ciorba";
            ProduseBusiness b = new ProduseBusiness();
            var found = b.Search(c);
            Assert.IsTrue(found.All(a => a.Title.Contains(c) || a.Details.Contains(c)));
            
        }

        [TestMethod]

        public void ListByPrice()
        {
            ProduseBusiness business = new ProduseBusiness();
            var produsebyPrice = business.ListByPrice();
            Assert.IsTrue(produsebyPrice[0].Price < produsebyPrice[1].Price &&
                produsebyPrice[0].Price < produsebyPrice[produsebyPrice.Count - 1].Price);
        }
    }
}
