using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.MD
{
    public class MdList : ElementBase
    {
        ListProperties props;
        public MdList(ListProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            string type = "";
            string output = "";

            if (props.type == "Ordered")
            {
                for (int i = 1; i < props.items.Length; i++)
                {
                    output += i + ". " + props.items[i] + "\n";
                }
            }
            else
            {
                for (int i = 1; i < props.items.Length; i++)
                {
                    output += "- " + props.items[i] + "\n";
                }
            }

            


            return output;
        }
    }
}
