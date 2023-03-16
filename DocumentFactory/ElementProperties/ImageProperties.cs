using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    public class ImageProperties : IElementProperties
    {
        public string url { get; set; }
        public string altText { get; set; }
        public string title { get; set; }
        
    }
}
