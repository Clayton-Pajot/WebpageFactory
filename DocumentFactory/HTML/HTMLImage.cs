using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HTMLImage : ElementBase
    {
        ImageProperties props;

        public HTMLImage(ImageProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            return $"<img src='{props.url}' atl='{props.altText}' title='{props.title}'/>";
        }
    }
}
