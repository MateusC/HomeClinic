using HomeClinic.Domain.Extension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HomeClinic.Domain.DTO
{
    [Serializable]
    [XmlRoot("DatabaseConfiguration")]
    public class ConfigurationXml
    {
        private static ConfigurationXml _xml;

        private ConfigurationXml() { }

        public String ConnectionString { get; set; }

        public Int32 Provider { get; set; }

        public static ConfigurationXml GetDatabaseConfig(String path)
        {
            try
            {
                var file = Directory.GetFiles(path).Where(x => x.Contains("DatabaseConfiguration.xml")).FirstOrDefault();
                
                if(file == null)
                {
                    var pieces = path.Split("\\".ToCharArray()).ToList();

                    pieces.RemoveAt(pieces.Count - 1);

                    String newPath = String.Join("\\", pieces);

                    GetDatabaseConfig(newPath);
                }
                else
                {
                    var content = File.ReadAllText(file);

                    content = content.RemoveNamespaceFromXml();

                    var xml = new XmlDocument();

                    xml.LoadXml(content);

                    xml = xml.RemoveAllNamespaces();

                    _xml = (ConfigurationXml)xml.OuterXml.DeserializeXML(typeof(ConfigurationXml));
                }
            }
            catch (Exception exception)
            {
                String messageError = String.Format("Ocorreu um erro ao buscar os dados do arquivo de configuração.\nErro: \"{0}\"", exception.Message);

                throw new Exception(messageError);
            }

            return _xml;
        }
    }
}
