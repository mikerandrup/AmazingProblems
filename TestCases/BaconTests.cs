using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.DegreesOfBacon;
using Problems.DegreesOfBacon.DataProvider;

namespace TestCases
{
    [TestClass]
    public class BaconTests
    {
        [TestMethod]
        public void DegreesOfBaconRunner()
        {
            WorkSummary ws = new DegreesOfBacon().FindSomeBacon();
            Assert.IsTrue(ws.TotalProductsExamined > 0);
            Assert.IsNotNull(ws.FirstMatchingProduct);
            Assert.AreEqual(Categories.Bacon, ws.FirstMatchingProduct.Category);
        }

        [TestMethod]
        public void ProductDataStoreReturnsData()
        {
            List<Product> products = ProductDataStore.GetRecommendations(1);
            Assert.IsNotNull(products);
            Assert.IsTrue(products.Count > 0);
        }
    }
}
