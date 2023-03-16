using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.MD
{
    internal class MdHeader : IElement
    {
        private HeaderProperties properties;

        public MdHeader(HeaderProperties properties)
        {
            this.properties = properties;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < properties.headerLevel; i++)
            {
                result += "#";
            }
            result += " " + properties.text;

            return result;
            //return $"Heading level{properties.headerLevel}>{properties.text}</h{properties.headerLevel}>";
        }
    }
}
