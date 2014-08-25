using System.Collections.Generic;

namespace Problems.DegreesOfBacon
{
    public class WorkQueue : Queue<WorkItem>
    {
        public WorkQueue() : base() {
            AlreadyEnqueued = new HashSet<long>();
        }
        
        public new bool Enqueue(WorkItem w) {
            if (AlreadyEnqueued.Contains(w.ProductToProcess.ProductId))
            {
                return false;
            }
            else
            {
                AlreadyEnqueued.Add(w.ProductToProcess.ProductId);
                base.Enqueue(w);
                return true;
            }
        }

        private HashSet<long> AlreadyEnqueued;
    }
}
