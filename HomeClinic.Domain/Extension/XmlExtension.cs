using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HomeClinic.Domain.Extension
{
    public static class XmlExtension
    {
        public static Object DeserializeXML(this String xml, Type classType)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
                {
                    XmlSerializer serializer = new XmlSerializer(classType);
                    object integration = serializer.Deserialize(reader);
                    return integration;
                }
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("Ocorreu um erro na desserialização, erro : {0} stacktrace: {1}", e.Message, e.StackTrace));
            }
        }

        public static XmlDocument RemoveAllNamespaces(this XmlDocument documentElement)
        {
            var xmlnsPattern = "\\s+xmlns\\s*(:\\w)?\\s*=\\s*\\\"(?<url>[^\\\"]*)\\\"";
            var outerXml = documentElement.OuterXml;
            var matchCol = Regex.Matches(outerXml, xmlnsPattern);
            foreach (var match in matchCol)
                outerXml = outerXml.Replace(match.ToString(), "");

            var result = new XmlDocument();
            result.LoadXml(outerXml);

            return result;
        }

        public static String RemoveNamespaceFromXml(this String xml)
        {
            int startIndex;
            int finalIndex;

            while (xml.IndexOf("xmlns=") != -1)
            {
                startIndex = xml.IndexOf("xmlns=");

                if (xml.Substring(startIndex - 1, 1) == " ")
                    startIndex += -1;

                finalIndex = xml.IndexOf("\"", startIndex + 1);
                if (finalIndex == -1)
                {
                    finalIndex = xml.IndexOf("'", startIndex + 1);
                    finalIndex = xml.IndexOf("'", finalIndex + 1) + 1;
                }
                else
                    finalIndex = xml.IndexOf("\"", finalIndex + 1) + 1;

                xml = xml.Replace(xml.Substring(startIndex, finalIndex - startIndex), "");
            }

            while (xml.IndexOf("xmlns:") != -1)
            {
                startIndex = xml.IndexOf("xmlns:");

                if (xml.Substring(startIndex - 1, 1) == " ")
                    startIndex += -1;

                finalIndex = xml.IndexOf("\"", startIndex + 1);
                if (finalIndex == -1)
                {
                    finalIndex = xml.IndexOf("'", startIndex + 1);
                    finalIndex = xml.IndexOf("'", finalIndex + 1) + 1;
                }
                else
                    finalIndex = xml.IndexOf("\"", finalIndex + 1) + 1;
                xml = xml.Replace(xml.Substring(startIndex, finalIndex - startIndex), "");
            }

            while (xml.IndexOf("xsi:schemaLocation=") != -1)
            {
                startIndex = xml.IndexOf("xsi:schemaLocation=");
                finalIndex = xml.IndexOf(".xsd") + 5;
                xml = xml.Replace(xml.Substring(startIndex, finalIndex - startIndex), "");
            }

            xml = Regex.Replace(xml, "((?<=</?)\\w+:(?<elem>\\w+)|\\w+:(?<elem>\\w+)(?==\"))", "${elem}");

            return xml;
        }
    }
}
