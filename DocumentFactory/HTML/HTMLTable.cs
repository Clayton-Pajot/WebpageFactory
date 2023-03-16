using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HTMLTable : ElementBase
    {
        TableProperties props;

        public HTMLTable(TableProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            string output = "<table>\n";
            string text = "";
            string tag = "";
            string[] rows; 
            for(int i = 0; i < props.items.Length; i++)
            {
                rows = props.items[i].Split('$');
                text = rows[0];

                if (text == "Head")
                {
                    tag = "th";
                }
                else
                {
                    tag = "td";
                }


                output += $"<tr>\n";

                for (int j = 1; j < rows.Length; j++)
                {
                    output += $"<{tag}>{rows[j]}</{tag}>\n";
                }

                output += $"</tr>";
            }


            output += "\n</table>";
            return output;
        }
    }
}
