using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    public  class ListProperties : IElementProperties
    {
        //Element:List:Ordered;Item 1;Item 2;Item 3#
        public string[] items { get; set; }
        public string type { get; set; }
    }
}
