using DocumentFactory.HTML;
using DocumentFactory.MD;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Director
{
    class Program
    {
        //class variables ------------------------------------------------
        static IDocument document;
        static IDocumentFactory documentFactory = null;
        static string docType = "";

        //Class Methods ------------------------------------------------
        static void CreateDocument(string[] commands)
        {
            

            switch(commands[0])
            {
                case "Markdown":
                    //throw new NotImplementedException(); //I ran out of time. I plan to still complete this part, but I figured I would get this much in before I lost too many marks
                    documentFactory = new MdDocFactory();
                    docType = ".md";
                    break;

                case "Html":
                    documentFactory = new HTMLDocFactory();
                    docType = ".html";
                    break;
            }

            document = documentFactory.CreateDocument(commands[1]);
        }


        static void Main(string[] args)
        {

            //------------------------------------------------------------  Main Variables  --------------
            Console.WriteLine("Program started.");
            string[] commands;
            string fileNameR = "CreateDocumentScript.txt";
            var list = File.ReadAllText(fileNameR);
            commands = list.Split('#');

            //IDocumentFactory factory = new IDocumentFactory();


            //------------------------------------------------------------  Parse Commands  --------------
            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');

                //IDocument document = null;


                //------------------------------------------------------------  Process Commands  --------------
                switch (commandList[0])
                {
                    case "Document":
                        CreateDocument(commandList[1].Split(';'));//factory method to determine whether html or markdown
                        break;

                    case "Element":
                        document.AddElement(documentFactory.CreateElement(commandList[1], commandList[2]));
                        break;

                    case "Run":
                        //document.RunDocument();// <--- code to save file

                        string fileNameW = $"index{docType}";
                        File.WriteAllText(fileNameW, document.RunDocument());
                        //File.Open(fileNameW, FileMode.);
                        System.Diagnostics.Process.Start(fileNameW);
                        //open created file
                        break;

                    default:
                        break;
                }
            }

            
            //------------------------------------------------------------  Write and Run Document  --------------

            Console.WriteLine("Program Done");
        }//end of main
    }//end of class
}
