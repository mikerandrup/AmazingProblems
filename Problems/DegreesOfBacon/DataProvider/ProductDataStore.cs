using System;
using System.Collections.Generic;

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

        private static long _nextProdId = 0;
        private static Product GenerateFakeProduct()
        {
            _nextProdId = (_nextProdId + 1) % 10000;
            return new Product()
            {
                ProductId = _nextProdId,
                Category = _nextProdId % 103 == 0 ? Categories.Bacon : Categories.NotBacon
            };
        }
    }
}
