using System.Collections.Generic;
using Problems.DegreesOfBacon.DataProvider;

namespace Problems.DegreesOfBacon
{
    public class DegreesOfBacon
    {
        public WorkSummary FindSomeBacon()
        {
            WS = new WorkSummary();
            SeedTheWorkQueue();
            ProcessWorkQueue();
            return WS;
        }

        private void ProcessWorkQueue()
        {
            while (WQ.Count > 0)
            {
                WorkItem w = WQ.Dequeue();

                WS.TotalProductsExamined++;

                if (w.ProductToProcess.Category == Categories.Bacon)
                {
                    WS.FirstMatchingProduct = w.ProductToProcess;
                    WS.DistanceFromSeedOfMatch = w.DistanceFromStart;
                    return;
                }
                else
                {
                    AddProductsToWorkQueue(
                        ProductDataStore.GetRecommendations(
                            w.ProductToProcess.ProductId
                        ),
                        w.DistanceFromStart + 1
                    );
                }
            }
        }

        private void SeedTheWorkQueue()
        {
            WQ = new WorkQueue();
            Product seedProduct = new Product()
            {
                ProductId = 1,
                Category = Categories.NotBacon
            };
            AddProductsToWorkQueue(
                new List<Product>() { seedProduct }
            );
            AddProductsToWorkQueue(
                ProductDataStore.GetRecommendations(seedProduct.ProductId)
            );
        }

        private void AddProductsToWorkQueue(List<Product> products, int distance = 0)
        {
            foreach (Product p in products)
            {
                if (WQ.Enqueue(new WorkItem()
                    {
                        ProductToProcess = p,
                        DistanceFromStart = distance
                    }))
                {
                    WS.TotalProductsEnqueued++;
                }

            }
        }

        private WorkQueue WQ;
        private WorkSummary WS;
    }
}
