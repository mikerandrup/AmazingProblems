using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.MabLids.EssayComponents.DynamicComponents
{
    public class DynamicWordComponent : DynamicComponent
    {
        public string NameOfWordType
        {
            get
            {
                return this.GetType().Name;
            }
        }

    }
}
