using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Marathon.Kittyhawk.Services;
using Marathon.Kittyhawk.Services.DataContracts;
using Marathon.Kittyhawk.Services.Interfaces;

namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// Various methods that provide common, generic functionality to the source feed
    /// orchestration components.
    /// </summary>
    public static class HelperMethods
    {
        public static bool CompareObjects<T>(T x, T y)
        {
            return CompareObjects(x, y, new List<string> { "ID", "Timestamp" });
        }
        /// <summary>
        /// Compares the property/field values of two objects of the same type.  If the values
        /// for each property/field are the same, then it returns true.  If there is a mismatch,
        /// then it returns false.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="x">First object</param>
        /// <param name="y">Second object</param>
        /// <param name="propertiesToSkipComparison">List of properties which should not be included in comparison</param>
        /// <returns>True if equivalent, false if not equivalent</returns>
        public static bool CompareObjects<T>(T x, T y, List<string> propertiesToSkipComparison)
        {
	        Type type = typeof(T);
	        PropertyInfo[] properties = type.GetProperties();
	        FieldInfo[] fields = type.GetFields();
	        int compareValue = 0;
	 
	        foreach (PropertyInfo property in properties)
	        {
                if (!propertiesToSkipComparison.Contains(property.Name) && !property.PropertyType.FullName.Contains("Marathon.Kittyhawk"))
                {
                    IComparable valx = property.GetValue(x, null) as IComparable;
					object valy = property.GetValue(y, null);

					if (valx == null && valy == null)
						continue;
					else if (valx == null && valy != null)
						return false;
					else
					{
						compareValue = valx.CompareTo(valy);
						if (compareValue != 0)
							return false;
					}
                }
	        }
	        foreach (FieldInfo field in fields)
	        {
                if (field.Name != "ID" && field.Name != "Timestamp")
                {
                    IComparable valx = field.GetValue(x) as IComparable;
					object valy = field.GetValue(y);

					if (valx == null && valy == null)
						continue;
					else if (valx == null && valy != null)
						return false;
					else
					{
						compareValue = valx.CompareTo(valy);
						if (compareValue != 0)
							return false;
					}
                }
	        }
	 
	        return true;
        }

        /// <summary>
        /// Converts a data table object to a list of key/value collections.
        /// </summary>
        /// <param name="t">DataTable object</param>
        /// <returns>Array of lookups populated with data from the DataTable</returns>
        public static List<Dictionary<string, string>> ConvertDataTableToStringCollection(DataTable t)
        {
            int rows = t.Rows.Count;
            int columns = t.Columns.Count;
            var collection = new List<Dictionary<string, string>>();

            // Loop through and create a dictionary for each row, setting the key to
            // the column name and the value to the content of the DataTable cell
            for (int i = 0; i < rows; i++)
            {
                collection.Add(new Dictionary<string, string>());
                for (int j = 0; j < columns; j++)
                {
                    if (t.Rows[i][j] == null || t.Rows[i][j] == DBNull.Value)
                        collection[i].Add(t.Columns[j].ColumnName, null);
                    else
                        collection[i].Add(t.Columns[j].ColumnName, t.Rows[i][j].ToString());
                }
            }

            return collection;
        }

        public static Dictionary<string, string> ConvertObjectToStringCollection(object obj)
        {
            Dictionary<string,string> source = (from x in obj.GetType().GetProperties() select x).ToDictionary(x => x.Name, x => (x.GetGetMethod().Invoke(obj, null) == null ? "" : x.GetGetMethod().Invoke(obj, null).ToString()));

            return source;
        }

		public static List<Dictionary<string, string>> ConvertListDictionaryToCaseInsensitive(List<Dictionary<string, string>> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = new Dictionary<string, string>(list[i], StringComparer.OrdinalIgnoreCase);
			}

			return list;
		}

		/// <summary>
		/// Helper method that converts the provided list of sets of key/value pairs
		/// to an XML document.
		/// </summary>
		/// <param name="source">Source data</param>
		/// <returns>Source data as an XML string</returns>
		public static string ToXML(this List<Dictionary<string, string>> source)
        {
            XDocument document = new XDocument(new XElement("Root"));

            foreach (var record in source)
            {
                XElement recordElement = new XElement("SourceRecord");

                foreach (KeyValuePair<string, string> element in record)
                {
                    string value = null, key = null;
                    if (element.Value != null && element.Value.Length > 0)
                    {
                        value = element.Value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;")
                            .Replace("\"", "&quot;").Replace("'", "&apos;").Replace("\a", ""); //.Replace("/", "").Replace("\\", "");
                    }

                    if (element.Key != null && element.Key.Length > 0)
                    {
                        key = element.Key.Replace("/", "").Replace("\\", "").Replace(" ", "");
                    }

                    recordElement.Add(new XElement(key, value));


                }

                document.Root.Add(recordElement);
            }

            return document.ToString(SaveOptions.DisableFormatting);
        }

        /// <summary>
        /// Decodes the source code schedule, stored as a string in the database, that
        /// describes which days and how often the integration is supposed to run.
        /// </summary>
        /// <param name="scheduleCode">Schedule code</param>
        /// <returns>DateTime for the next scheduled run</returns>
        public static DateTime GetNextScheduledRun(string scheduleCode)
        {
            DateTime nextScheduledRun;

            // First split on the "|" token which divides the code
            List<string> tokens = scheduleCode.Split('|').ToList();

            // First token indicates if this is an hourly schedule or runs at specific
            // hours throughout the day
            bool isHourly = tokens[0] == "Hourly" ? true : false;

            if (isHourly)
            {
                // If hourly, the second token contains a list of minutes after the hour to run
                int hour = DateTime.Now.Hour;
                List<int> minutes = tokens[1].Split(',').Select(x => int.Parse(x)).OrderBy(x => x).ToList();
                int minute = minutes.Where(x => x > DateTime.Now.AddMinutes(1).Minute).DefaultIfEmpty(-1).First();

                if (minute == -1)
                {
                    // Next run will occur during the following hour
                    hour++;
                    minute = minutes.First();
                }

                if (hour == 24)
                {
                    // Next run will occur during the first hour of the next day
                    nextScheduledRun = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day, 0, minute, 0).AddDays(1);
                }
                else
                {
                    nextScheduledRun = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day, hour, minute, 0);
                }
            }
            else
            {
                // If not hourly, the second token contains a list of hours to run
                List<int> hours = tokens[1].Split(',').Select(x => int.Parse(x)).OrderBy(x => x).ToList();
                int hour = hours.Where(x => x > DateTime.Now.Hour).DefaultIfEmpty(-1).First();

                if (hour == -1)
                {
                    // Next run will occur at the first scheduled time on the next day
                    hour = hours.First();
                    nextScheduledRun = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day, hour, 0, 0).AddDays(1);
                }
                else
                {
                    nextScheduledRun = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day, hour, 0, 0);
                }
            }

            return nextScheduledRun;
        }

        /// <summary>
        /// Helper method to identify new files from the IBEX hybrid feed.
        /// </summary>
        /// <param name="directory">File directory</param>
        /// <param name="lastTimestamp">Most recent timestamp</param>
        /// <param name="IsInventory">Inventory (83) or bulk transfer</param>
        /// <returns>List of file names</returns>
        public static List<string> GetNewIBEXFiles(
            string directory, DateTime lastTimestamp, bool IsInventory)
        {
            IEnumerable<string> files = null;
            if (IsInventory)
            {
                files = Directory.EnumerateFiles(directory)
                    .Where(x => x.Contains("KS1883"));
            }
            else
            {
                files = Directory.EnumerateFiles(directory)
                    .Where(x => x.Contains("KS18") && !x.Contains("KS1883"));
            }

            var newFiles = new List<string>();
            foreach (var file in files)
            {
                DateTime fileDateTime = DateTime.ParseExact(
                    file.Split('_').Last().Split('.').First(), "yyMMddHHmm", CultureInfo.InvariantCulture);
                if (fileDateTime > lastTimestamp)
                    newFiles.Add(file);
            }

            return newFiles.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// Helper method to identify and read new files from the Third Party Business Associates.
        /// </summary>
        public static List<string> GetNewThirdPartyInventoryFiles(
            string directory, DateTime lastTimestamp)
        {
            IEnumerable<string> files = null;

            files = Directory.EnumerateFiles(directory)
                    .Where(x => x.Contains(".csv"));

            var newFiles = new List<string>();
            foreach (var file in files)
            {

                DateTime fileDateTime = DateTime.ParseExact(file.Split('-').Last().Split('.').First(), "MMddyyyy hhmm", CultureInfo.InvariantCulture);
                if (fileDateTime > lastTimestamp)
                    newFiles.Add(file);
            }

            return newFiles.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// Helper method for creating new log entries.
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="detail">Detail</param>
        /// <param name="description">Description</param>
        /// <param name="metric">Metric</param>
        /// <param name="metricDesc">Metric description</param>
        /// <returns>Instantiated log object</returns>
        public static Log CreateLog(string user, string detail, string description, int? metric, string metricDesc)
        {
            if (metric.HasValue)
                Console.WriteLine(String.Format("({0}) {1} ({2})", DateTime.Now, description, metric));
            else
                Console.WriteLine(String.Format("({0}) {1}", DateTime.Now, description));

            return new Log
            {
                Timestamp = DateTime.Now,
                User = user.ToUpper(),
                EventType = EventType.Integration,
                EventDetail = detail,
                Description = description,
                Metric = metric,
                MetricDescription = metricDesc
            };
        }

        /// <summary>
        /// Helper method for creating new error log entries.
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="detail">Event detail</param>
        /// <param name="e">Exception</param>
        /// <returns>Instantiated error log object</returns>
        public static Error CreateErrorLog(string user, string detail, Exception e)
        {
            Error error = new Error
            {
                Timestamp = DateTime.Now,
                User = user.ToUpper(),
                EventType = EventType.Integration,
                EventDetail = detail,
                Description = e.Message,
                StackTrace = e.StackTrace
            };

			Exception ex = e;
			while (ex.InnerException != null)
			{
				error.Description += $" -> {ex.InnerException.Message}";
				error.StackTrace += $"{Environment.NewLine}{Environment.NewLine}---INNER EXCEPTION---{Environment.NewLine}{e.InnerException.StackTrace}";

				ex = ex.InnerException;
			}

            Console.WriteLine($"({DateTime.Now}) {error.Description}");
            return error;
        }

        /// <summary>
        /// Helper method that contains logic for finding and sending unpublished bulk transfer records
        /// to the service bus.
        /// </summary>
        /// <param name="unpublishedBulkTransfers">Unpublished bulk transfers</param>
        /// <param name="factory">Service factory</param>
        /// <param name="user">User</param>
        /// <param name="dataSource">Data source</param>
        /// <param name="uri">Service bus URI</param>
        /// <param name="environment">Envoironment</param>
        public static void PublishUnsentBulkTransfers(List<BulkTransfer> unpublishedBulkTransfers, 
            KHServiceFactory factory, string user, string dataSource, string uri, string environment)
        {
            if (unpublishedBulkTransfers.Count > 0)
            {
                factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                    user, dataSource, "Sending unpublished bulk transfers to the service bus...", null, null)));
                try
                {
                    if (dataSource == "RailTrac Bulk Transfer" || dataSource == "MPL Bulk Transfer" || dataSource == "Transport4")
                    {
                        // Only want activity that isn't at a refinery (Galveston Bay is not included
                        // in this list - since they do not enter movements through the yield IBEX
                        // feed, they do want these to come in as movement documents)
                        var refineryIDs = new List<int> { 1620, 1621, 1629, 1636, 1682, 1694 };
                                                
                        List<BulkTransfer> unpublishedToSend = new List<BulkTransfer>();

                        foreach (var transfer in unpublishedBulkTransfers)
                        {                   
                            //don't skip any railtrac Asphalt/specialties records
                            if (dataSource == "RailTrac Bulk Transfer"  && transfer.Product != null && (transfer.Product.Commodity == "Asphalt" || transfer.Product.Commodity == "Specialties"))
                                unpublishedToSend.Add(transfer);
                            else 
                            {//skip the records based on refineries
                                if (transfer.Facility!= null && !refineryIDs.Contains(transfer.Facility.LocationKey))
                                {
                                    //for commodities other than asphalt/Specialties and products other than PETCOKE set
                                    //a) Railtrac comm_amt as the GrossQuantiy
                                    //b) NetQty and NetQtyUnit needs be set to null
                                    if (dataSource == "RailTrac Bulk Transfer" && transfer.Product != null &&  !(transfer.Product.Commodity== "Asphalt" || transfer.Product.Commodity == "Specialties" || transfer.OriginProductCode== "PETCOKE"))
                                    {
                                        transfer.GrossQuantity = transfer.ScheduledQuantity;
                                        transfer.NetQuantity = null;
                                        transfer.NetQuantityUnit = null;
                                    }
                                        unpublishedToSend.Add(transfer);
                                }
                                    
                            }                           
                        }

                        unpublishedToSend = ServiceBusClient.PublishBulkTransfersToServiceBus(
                            unpublishedToSend, environment, uri);

                        // Mark the rest as published so we ignore next time
                        var notSent = unpublishedBulkTransfers.Except(unpublishedToSend);
                        foreach (var transfer in notSent)
                        {
                            transfer.IsPublished = true;
                        }
                    }
                    else
                    {
                        // Publish all
                        unpublishedBulkTransfers = ServiceBusClient.PublishBulkTransfersToServiceBus(
                            unpublishedBulkTransfers, environment, uri);
                    }

                    // Save the update to the Kittyhawk database
                    factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                        user, dataSource, "Updating published bulk transfers in the database",
                        unpublishedBulkTransfers.Count, "Records Processed")));
                    factory.UseService((IAdminService s) =>
                        s.SaveOrDeleteBulkTransfers(unpublishedBulkTransfers, SaveMode.Update));
                }
                catch (Exception e)
                {
                    // If an exception occurs, record the details and pass to the error service
                    factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                        user, dataSource, "An error occurred.  See error log for details.", null, null)));
                    factory.UseService((IErrorService s) => s.SaveErrorEntry(HelperMethods.CreateErrorLog(
                        user, dataSource, e)));
                }
            }
        }

        /// <summary>
        /// Helper method that contains logic for finding and sending unpublished inventory records
        /// to the service bus.
        /// </summary>
        /// <param name="unpublishedInventories">Unpublished inventories</param>
        /// <param name="factory">Service factory</param>
        /// <param name="user">User</param>
        /// <param name="dataSource">Data source</param>
        /// <param name="uri">Service bus URI</param>
        /// <param name="environment">Envoironment</param>
        public static void PublishUnsentInventories(List<Inventory> unpublishedInventories,
            KHServiceFactory factory, string user, string dataSource, string uri, string environment)
        {
            if (unpublishedInventories.Count > 0)
            {
                factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                    user, dataSource, "Sending unpublished inventories to the service bus...", null, null)));
                try
                {
                    // Publish those flagged as needing sent to the service bus
                    unpublishedInventories = ServiceBusClient.PublishInventoriesToServiceBus(
                        unpublishedInventories, environment, uri);

                    if (unpublishedInventories.Exists(x => x.OOSIndicator == false || x.OOSIndicator == null))
                    {
                        // Save the update to the Kittyhawk database
                        factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                            user, dataSource, "Updating published inventories in the database",
                            unpublishedInventories.Count, "Records Processed")));
                        factory.UseService((IAdminService s) =>
                            s.SaveOrDeleteInventories(unpublishedInventories, SaveMode.Update));
                    }
                }
                catch (Exception e)
                {
                    // If an exception occurs, record the details and pass to the error service
                    factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                        user, dataSource, "An error occurred.  See error log for details.", null, null)));
                    factory.UseService((IErrorService s) => s.SaveErrorEntry(HelperMethods.CreateErrorLog(
                        user, dataSource, e)));
                }
            }
        }

        /// <summary>
        /// Helper method that contains logic for finding and sending unpublished transaction records
        /// to the service bus.
        /// </summary>
        /// <param name="unpublishedTransactions">Unpublished transactions</param>
        /// <param name="factory">Service factory</param>
        /// <param name="user">User</param>
        /// <param name="dataSource">Data source</param>
        /// <param name="uri">Service bus URI</param>
        /// <param name="environment">Envoironment</param>
        public static void PublishUnsentTransactions(List<IBEXTransaction> unpublishedTransactions,
            KHServiceFactory factory, string user, string dataSource, string uri, string environment)
        {
            if (unpublishedTransactions.Count > 0)
            {
                factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                    user, dataSource, "Sending unpublished transactions to the service bus...", null, null)));
                try
                {
                    // Publish those flagged as needing sent to the service bus
                    unpublishedTransactions = ServiceBusClient.PublishIBEXTransactionsToServiceBus(
                        unpublishedTransactions, environment, uri);

                    // Save the update to the Kittyhawk database
                    factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                        user, dataSource, "Updating published transactions in the database",
                        unpublishedTransactions.Count, "Records Processed")));
                    factory.UseService((IAdminService s) =>
                        s.SaveOrDeleteIBEXTransactions(unpublishedTransactions, SaveMode.Update));
                }
                catch (Exception e)
                {
                    // If an exception occurs, record the details and pass to the error service
                    factory.UseService((ILogService s) => s.SaveLogEntry(HelperMethods.CreateLog(
                        user, dataSource, "An error occurred.  See error log for details.", null, null)));
                    factory.UseService((IErrorService s) => s.SaveErrorEntry(HelperMethods.CreateErrorLog(
                        user, dataSource, e)));
                }
            }
        }

        /// <summary>
        /// Converts the provided source and start date into the string format used
        /// by the "process identifier" field.
        /// </summary>
        /// <param name="source">Data source</param>
        /// <param name="start">Start date</param>
        /// <returns>Process identifier string</returns>
        public static string GetProcessIdentifier(string source, DateTime start)
        {
            return source + " " + start.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
