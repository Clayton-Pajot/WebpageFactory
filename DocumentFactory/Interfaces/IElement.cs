using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Interfaces
{
    public interface IElement
    {
        string ToString();
    }//end of IElement


    public class ElementBase : IElement
    {
        public override string ToString()
        {
            return "";
        }//ToString


    }//end of ElementBase


}//end of namespace
