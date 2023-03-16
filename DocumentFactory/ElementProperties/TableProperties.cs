using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    public class TableProperties : IElementProperties
    {
        public string[] items { get; set; }
        public bool hasHeader { get; set; }
    }
}
