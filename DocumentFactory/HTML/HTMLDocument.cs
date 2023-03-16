using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HTMLDocument : IDocument
    {
        List<IElement> elements = new List<IElement>();
        public string title { get; set; }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        public string RunDocument()
        {
            Console.WriteLine("Running HTML Document Creation...");
            string output = "";
            foreach (var element in elements)
            {
                output += element.ToString() + "\n";
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
