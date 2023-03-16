using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DocumentFactory.MD
{
    public class MdImage : ElementBase
    {
        ImageProperties props;

        public MdImage(ImageProperties properties)
        {
            this.props = properties;
        }

        public override string ToString()
        {
            return $"![{props.altText}]({props.url} \"{props.title}\")";
        }
    }
}
