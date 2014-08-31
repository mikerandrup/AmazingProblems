using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.MabLids.EssayComponents;
using Problems.MabLids.EssayComponents.DynamicComponents;

namespace Problems.MabLids
{
    public class Essay
    {
        public Essay() : base()
        {
            Components = new List<EssayComponent>();
        }

        public Essay Append(EssayComponent part)
        {
            Components.Add(part);
            return this;
        }

        private List<EssayComponent> Components;

        public string[] NeededItems
        {
            get
            {
                List<string> needed = new List<string>();
                foreach (var wc in WordComponents)
                {
                    needed.Add(wc.NameOfWordType);
                }
                return needed.ToArray();
            }
        }

        private List<DynamicWordComponent> WordComponents
        {
            get {
                var wc = new List<DynamicWordComponent>();

                foreach (var c in Components)
                {
                    if (c.GetType() == typeof(DynamicWordComponent))
                    {
                        wc.Add((DynamicWordComponent)c);
                    }
                }
                return wc;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var c in Components)
            {
                sb.Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
