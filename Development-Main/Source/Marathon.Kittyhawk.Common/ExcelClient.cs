using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Xml.Linq;


namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// This static class exposes methods to assist in parsing data from Excel spreadsheets.
    /// </summary>
    public static class ExcelClient
    {
        /// <summary>
        /// Parses data from a CSV file into a list of key/value collections.
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>Array of lookups populated with data from the CSV file</returns>
        public static List<Dictionary<string, string>> ParseCSVFileIntoStringCollection(string path, string delimiter = "~")
        {
            var collection = new List<Dictionary<string, string>>();
            StreamReader reader = new StreamReader(path);

            var headerTokens = reader.ReadLine().Split(delimiter.ToCharArray()).ToList();

            while (!reader.EndOfStream)
            {
                var record = new Dictionary<string, string>();
                var tokens = reader.ReadLine().Split(delimiter.ToCharArray()).ToList();

                for (int i = 0; i < tokens.Count; i++)
                {
                    if (headerTokens.Count > i && !record.ContainsKey(headerTokens[i]) &&
                        headerTokens[i] != "" && headerTokens[i][0] != ' ')
                    {
                        record.Add(headerTokens[i], tokens[i].Trim());
                    }
                }

                collection.Add(record);
            }

            reader.Close();
            return collection;
        }



    }
}
