using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PocSII.DteProcessor.Common
{
    public static class XmlHelper {
        public static  string SerializeToXml<T>(T obj) {

            var serializer = new XmlSerializer(typeof(T));

            var settings = new XmlWriterSettings {
                Indent = true,
                Encoding = Encoding.GetEncoding("ISO-8859-1"),
                OmitXmlDeclaration = false
            };

            using var stringWriter = new StringWriterWithEncoding(Encoding.GetEncoding("ISO-8859-1"));
            using var xmlWriter = XmlWriter.Create(stringWriter, settings);
            serializer.Serialize(xmlWriter, obj);
            return stringWriter.ToString();
        }
    }

    public class StringWriterWithEncoding : StringWriter {
        private readonly Encoding _encoding;

        public StringWriterWithEncoding(Encoding encoding) {
            _encoding = encoding;
        }

        public override Encoding Encoding => _encoding;
    }
}
