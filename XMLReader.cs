using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PV_Olsbro_2024
{
    internal static class XMLReader
    {

        public static string[] ReadConnectionString(string Path)
        {
            string[] output = new string[4];
            XmlDocument Doc = new XmlDocument();

            Doc.Load(Path);

            XmlNode node = Doc.SelectSingleNode("/connection/add");
            output[0] = node.Attributes["id"].Value;
            output[1] = node.Attributes["password"].Value;
            output[2] = node.Attributes["catalog"].Value;
            output[3] = node.Attributes["source"].Value;
            return output;
        }
    }
}
