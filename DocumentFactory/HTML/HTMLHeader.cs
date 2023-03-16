using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    internal class HTMLHeader: IElement
    {
        private HeaderProperties properties;

        public HTMLHeader(HeaderProperties properties)
        {
            this.properties = properties;
        }
        public override string ToString()
        {
            return $"<h{properties.headerLevel}>{properties.text}</h{properties.headerLevel}>";
        }
    }
}
