using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    internal class HeaderProperties : IElementProperties
    {
        //<h1>text</h1>

        public int headerLevel;
        public string text;


    }
}
