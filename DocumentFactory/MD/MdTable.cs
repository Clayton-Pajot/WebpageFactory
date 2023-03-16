using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.MD
{
    public class MdTable : ElementBase
    { 
        TableProperties props;

        public MdTable(TableProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            string output = "";
            string text = "";
            string tag = "";
            string[] rows;
            int colWidth = 0;

            //for (int i = 0; i < props.items.Length; i++)
            //{
            //    rows = props.items[i].Split('$');
            //    for (int j = 0; j < rows.Length; j++)
            //    {
            //        int temp = Int32.Parse(rows[j]);
            //        if(temp > colWidth)
            //        {
            //            colWidth = temp;
            //        }
            //    }
            //}

            for (int i = 0; i < props.items.Length; i++)
            {
                rows = props.items[i].Split('$');
                text = rows[0];
                output += "|";

                if (text == "Head")
                {
                    
                    for (int j = 1; j < rows.Length; j++)
                    {
                        output += rows[j] + " |";
                    }
                    output += "\n|";
                    for (int j = 1; j < rows.Length; j++)
                    {
                        output += "------|";
                    }
                    output += "\n";
                    
                }
                else
                {
                    for (int j = 1; j < rows.Length; j++)
                    {
                        output += rows[j] + " |";
                    }
                    output += "\n";
                }
            }

            return output;
        }
    }
}
