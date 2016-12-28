using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.MabLids.EssayComponents
{
    public class DynamicComponent : EssayComponent
    {
        public DynamicComponent SetValue(string value)
        {
            _value = value;
            return this;
        }
        private string _value;

        public override string ToString()
        {
            return _value;
        }
    }
}
