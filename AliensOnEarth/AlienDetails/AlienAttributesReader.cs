using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml; //For Xml parsing

namespace AliensOnEarth.AlienDetails
{
    /*
   Author: Avinash
   Company:Multunus Software
   This Class is used to read the attributes from the Xml File and store in a list.
   */
    class AlienAttributesReader
    {
        static List<string> alienAttributesList = new List<string>();

        public static List<string> GetAttributeslist()
        {
            ReadAttributes();
            return alienAttributesList;
        }

        public static void ReadAttributes()
        {

            try
            {
                //Path to the Xml file
                XmlReader xmlReader = XmlReader.Create(@"C:/Users/Kasper/Documents/Visual Studio 2012/Projects/optimized/AliensOnEarth/AliensOnEarth-improved-/AliensOnEarthAlienAttributesList.xml");
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "alien") && (xmlReader.HasAttributes))
                    {

                        alienAttributesList.Add((xmlReader.GetAttribute("attributes")));

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
                

            }

        }

    }
}
