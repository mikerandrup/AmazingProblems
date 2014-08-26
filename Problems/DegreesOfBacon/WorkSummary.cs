using System;
using Problems.DegreesOfBacon.DataProvider;

namespace Problems.DegreesOfBacon
{
    public class WorkSummary
    {
        private const string messageTemplate =
            "{0} products were enqueued, and {1} were actually checked"
            + "before finding Product ID {2} in the bacon category {3}"
            + "hops away from the original product.";

        public override string ToString()
        {
            return String.Format(
                messageTemplate,
                TotalProductsEnqueued,
                TotalProductsExamined,
                FirstMatchingProduct.ProductId,
                DistanceFromStart
            );
        }


        public int TotalProductsEnqueued { get; set; }

        public int TotalProductsExamined { get; set; }

        public Product FirstMatchingProduct { get; set; }
        public int DistanceFromStart { get; set; }
    }
}
