using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.MD
{
    public class MdDocFactory : IDocumentFactory
    {
        //Helper methods =========================================================================

        //------------------------------------------------------------  Create Image  --------------
        protected IElement CreateImage(string props)
        {
            var properties = props.Split(';');
            var imgProps = new ImageProperties
            {
                url = properties[0],
                altText = properties[1],
                title = properties[2]
            };
            return new MdImage(imgProps);
        }

        //------------------------------------------------------------  Create Header  --------------
        protected IElement CreateHeader(string props)
        {
            var properties = props.Split(';');
            var headerProp = new HeaderProperties()
            {
                headerLevel = Convert.ToInt32(properties[0]),
                text = properties[1]
            };

            return new MdHeader(headerProp);
        }

        //------------------------------------------------------------  Create List  --------------
        protected IElement CreateList(string props)
        {
            var properties = props.Split(';');
            var listProp = new ListProperties()
            {
                type = properties[0],
                items = properties
            };
            return new MdList(listProp);

        }


        //------------------------------------------------------------  Create Table  --------------
        protected IElement CreateTable(string props)
        {
            var properties = props.Split(';');
            bool header = false;

            if (properties[0] == "Head")
            {
                header = true;
            }
            else
            {
                header = false;
            }

            var tableProp = new TableProperties()
            {
                hasHeader = header,
                items = properties
            };
            return new MdTable(tableProp);
        }

        //Creation Methods =========================================================================

        //------------------------------------------------------------  Create Document  --------------
        public IDocument CreateDocument(string fileName)
        {
            MdDocument doc = new MdDocument();
            doc.title = fileName;

            return doc;
        }

        //------------------------------------------------------------  Create Element  --------------
        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Image":
                    return CreateImage(props);
                case "Header":
                    return CreateHeader(props);
                case "List":
                    return CreateList(props);
                case "Table":
                    return CreateTable(props);
                default:
                    return null;
            }
        }//end of CreateElement
    }//end of MdDocFacotry
}//end of namespace
