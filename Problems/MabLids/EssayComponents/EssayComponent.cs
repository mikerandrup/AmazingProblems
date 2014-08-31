using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.MabLids.EssayComponents
{
    public class EssayComponent
    {
        protected string value = String.Empty;

        public override string ToString()
        {
            return value;
        }
    }
}
