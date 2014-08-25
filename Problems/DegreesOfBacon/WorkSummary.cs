using Problems.DegreesOfBacon.DataProvider;

namespace Problems.DegreesOfBacon
{
    public class WorkSummary
    {
        public int TotalProductsEnqueued { get; set; }

        public int TotalProductsExamined { get; set; }

        public Product FirstMatchingProduct { get; set; }
        public int DistanceFromSeedOfMatch { get; set; }
    }
}
