using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.DegreesOfBacon.DataProvider
{
    public static class ProductDataStore
    {
        public static List<Product> GetRecommendations(long prodId)
        {
            var prods = new List<Product>();
            for (int count = new Random().Next(maxValue: 10) + 5; count > 0; count--)
            {
                prods.Add(GenerateFakeProduct());
            }
            return prods;
        }

        private static long _lastId = 10001;
        private static long _idIncrement = 137; // a nice prime
        private static Product GenerateFakeProduct()
        {
            var rand = new Random();
            return new Product()
            {
                ProductId = _lastId += _idIncrement,
                Category = rand.Next(10) == 1 ? Categories.Bacon : Categories.NotBacon
            };
        }
    }
}
