using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class containing XML helper methods.
    /// </summary>
    public static class XmlConverter
    {
        /// <summary>
        /// Helper method that converts the provided set of key/value pairs
        /// to an XML document.
        /// </summary>
        /// <param name="source">Source data</param>
        /// <returns>Source data as an XML string</returns>
        public static string ToSourceRecordXML(this Dictionary<string, string> source)
        {
            XDocument document = new XDocument(new XElement("SourceRecord"));
            foreach (KeyValuePair<string, string> element in source)
            {
                string value = null, key = null;
                if (element.Value != null && element.Value.Length > 0)
                {
                    value = element.Value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;")
                        .Replace("\"", "&quot;").Replace("'", "&apos;").Replace("\a", "");
                }

                if (element.Key != null && element.Key.Length > 0)
                {
                    key = element.Key.Replace("/", "").Replace("\\", "").Replace(" ", "");
                }

                
                document.Root.Add(new XElement(key, value));
            }

            return document.ToString(SaveOptions.DisableFormatting);
        }

        /// <summary>
        /// Helper method that converts an xml string from a queued message back into
        /// a list of collections of key/value pairs.
        /// </summary>
        /// <param name="xml">Raw XML data</param>
        /// <returns>Structured key/value pairs collection</returns>
        public static List<Dictionary<string, string>> ConvertXMLToCollection(string xml)
        {
            var collection = new List<Dictionary<string, string>>();
            XDocument document = XDocument.Parse(xml);

            var records = document.Root.Elements("SourceRecord");
            foreach (var record in records)
            {
                var dict = new Dictionary<string, string>();
                foreach (var element in record.Elements())
                {
                    dict.Add(element.Name.ToString(), element.Value);
                }

                collection.Add(dict);
            }

            return collection;
        }

        static string HandleInvalidXmlCharacters(string xml, bool strip = false)
        {
            try
            {
                // throws exception if string contains any invalid characters.
                return XmlConvert.VerifyXmlChars(xml);
            }
            catch
            {
                StringBuilder sb = new StringBuilder();

                foreach (var c in xml)
                {
                    if (XmlConvert.IsXmlChar(c))
                        sb.Append(c);
                    else
                        if (!strip)
                            sb.Append(string.Format("[0x{0:X2}]", (short)c));
                }

                return sb.ToString();
            }
        }
    }
}
