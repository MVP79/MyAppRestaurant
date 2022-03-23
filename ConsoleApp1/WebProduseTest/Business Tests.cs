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
    }
}
