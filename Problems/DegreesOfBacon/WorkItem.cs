using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.DegreesOfBacon.DataProvider;

namespace Problems.DegreesOfBacon
{
    public class WorkItem
    {
        public Product ProductToProcess { get; set; }
        public int DistanceFromStart { get; set; }
    }
}
