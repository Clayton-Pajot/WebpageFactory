using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HTMLList : ElementBase
    {
        ListProperties props;
        public HTMLList(ListProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            string type = "";
            string output = "";

            if (props.type == "Ordered")
            {
                type = "ol";
            }
            else
            {
                type = "ul";
            }

            for (int i = 1; i < props.items.Length; i++)
            {
                output += "\n<li>" + props.items[i] + "</li>";
            }
            
            
            return $"\n<{type}>"+ output + $"\n</{type}>";
        }
    }
}
