using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLValidation
{
    class Program
    {

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            //doc.LoadXml(@"C:\Users\anders\KEA\SoftwareTesting\XML\XMLValidation\XMLValidation\Product.xml");
            doc.Load(new StreamReader(@"C:\Users\anders\KEA\SoftwareTesting\XML\XMLValidation\XMLValidation\Product.xml"));
            string text = "";
            if (doc.DocumentElement != null)
            {
                text += doc.DocumentElement.Name + ":\n  ";
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    text += node.Name + ": " + node.InnerText;
                }
                Console.WriteLine(text);
            }

            
            

            Console.ReadKey();
        }


    }
}
