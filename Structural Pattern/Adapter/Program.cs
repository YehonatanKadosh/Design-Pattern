using Adapter.PlugTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /// Example1 to Adapter Pattern
            UK_Plug ForeignPlug = new UK_Plug();

            ES_Plug MyPlug = ForeignPlug.Adapt_To_EU()
                                        .Adapt_To_ES();// Also using Builder

            //United Kingdom's Plug Created
            //Inserting the United Kingdom's Plug in the EU Adapter
            //European Plug Created
            //Inserting the European Plug in the ES Adapter
            //Spanish Plug Created



            /// Example2 for Adapter pattern 
            //onverting an XML into a JSON string   
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(
                $"<note>\n" +
                    $"\t<to>Tove</to>\n" +
                    $"\t<from>Jani</from>\n" +
                    $"\t<heading>Reminder</heading>\n" +
                    $"\t<body>Don't forget me this weekend!</body>\n" +
                $"</note>");
            // To convert Xml string into json string
            string jsonText = JsonConvert.SerializeXmlNode(doc); // Adapter from Xml to Json
            Console.WriteLine(jsonText);

            // To convert Json string into Xml string
            doc = JsonConvert.DeserializeXmlNode(jsonText); // Adapter from Json to Xml
            Console.WriteLine(doc.InnerXml);
        }
    }
}
