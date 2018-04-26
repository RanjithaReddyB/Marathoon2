using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// Data structure to help manage passing data back from PI queries.
    /// </summary>
    public class PITagValues
    {
        public string Key { get; set; }
        public string Tag { get; set; }
        public Dictionary<string, string> Values { get; set; }
        public bool IsInvalid { get; set; }

        public PITagValues()
        {
            Values = new Dictionary<string, string>();
        }
    }

    /// <summary>
    /// This static class exposes methods for obtaining data from a PI server.
    /// </summary>
    public static class PIClient
    {
        /// <summary>
        /// Retrieves the specified values from PI.
        /// </summary>
        /// <param name="sdk">PI SDK object</param>
        /// <param name="server">PI server</param>
        /// <param name="tag">PI tag</param>
        /// <returns>String value returned by the snapshot, or null</returns>
        public static string GetSnapshotValueFromPI(PISDK.PISDK sdk, string server, string tag)
        {
            string result = null;

            try
            {
                PISDK.PIValue piValue = sdk.Servers[server].PIPoints[tag].Data.Snapshot;

                if (piValue.IsGood())
                {
                    if (piValue.Value.GetType().IsCOMObject)
                    {
                        PISDK.DigitalState state = (PISDK.DigitalState)piValue.Value;
                        result = state.Code.ToString();
                    }
                    else
                    {
                        result = piValue.Value.ToString();
                    }
                }
            }
            catch (Exception)
            {
                // If the tag does not exist on the server it will throw an exception -
                // there doesn't appear to be a way around this so ignore it
            }

            return result;
        }

        /// <summary>
        /// Retrieves the specified values from PI.
        /// </summary>
        /// <param name="sdk">PI SDK object</param>
        /// <param name="server">PI server</param>
        /// <param name="key">Tag identifier</param>
        /// <param name="tag">PI tag</param>
        /// <param name="start">Start date</param>
        /// <returns>Timestamp/value pairs</returns>
        public static PITagValues GetValuesFromPI(
            PISDK.PISDK sdk, string server, string key, string tag, DateTime start)
        {
            PITagValues result = new PITagValues();
            result.Key = key;
            result.Tag = tag;

            try
            {
                PISDK.PIValues piValues = sdk.Servers[server].PIPoints[tag].Data.RecordedValues(start, "*");

                if (piValues.Count > 0)
                {
                    DateTime lastReading = piValues[1].TimeStamp.LocalDate;

                    for (int i = 1; i <= piValues.Count; i++)
                    {
                        if (piValues[i].IsGood())
                        {
                            DateTime date = piValues[i].TimeStamp.LocalDate;
                            string value = null;

                            if (piValues[i].Value.GetType().IsCOMObject)
                            {
                                PISDK.DigitalState state = (PISDK.DigitalState)piValues[i].Value;
                                value = state.Code.ToString();

                                if (!result.Values.ContainsKey(date.ToString()))
                                {
                                    result.Values.Add(date.ToString(), value);
                                }
                            }
                            else
                            {
                                value = piValues[i].Value.ToString();

                                if ((date - lastReading).TotalMinutes >= 60 &&
                                    !result.Values.ContainsKey(date.ToString()))
                                {
                                    lastReading = date;
                                    result.Values.Add(date.ToString(), value);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // If the tag does not exist on the server it will throw an exception -
                // there doesn't appear to be a way around this so ignore it and mark
                // the tag as invalid
                result.IsInvalid = true;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the specified values from PI.
        /// </summary>
        /// <param name="sdk">PI SDK object</param>
        /// <param name="server">PI server</param>
        /// <param name="tags">List of PI tags</param>
        /// <param name="start">Start date</param>
        /// <returns>Collection of timestamp/value pairs</returns>
        public static List<PITagValues> GetValuesFromPI(
            PISDK.PISDK sdk, string server, Dictionary<string, string> tags, DateTime start)
        {
            var resultSet = new List<PITagValues>();

            foreach (var tag in tags)
            {
                var result = new PITagValues();
                result.Key = tag.Key;
                result.Tag = tag.Value;

                if (tag.Value != null)
                {
                    try
                    {
                        PISDK.PIValues piValues = sdk.Servers[server].PIPoints[tag.Value].Data.RecordedValues(
                            start, "*");

                        if (piValues.Count > 0)
                        {
                            DateTime lastReading = piValues[1].TimeStamp.LocalDate;

                            for (int i = 1; i <= piValues.Count; i++)
                            {
                                if (piValues[i].IsGood())
                                {
                                    DateTime date = piValues[i].TimeStamp.LocalDate;
                                    string value = null;

                                    if (piValues[i].Value.GetType().IsCOMObject)
                                    {
                                        PISDK.DigitalState state = (PISDK.DigitalState)piValues[i].Value;
                                        value = state.Code.ToString();

                                        if (!result.Values.ContainsKey(date.ToString()))
                                        {
                                            result.Values.Add(date.ToString(), value);
                                        }
                                    }
                                    else
                                    {
                                        value = piValues[i].Value.ToString();

                                        if (i == 1 || ((date - lastReading).TotalMinutes >= 60 &&
                                            !result.Values.ContainsKey(date.ToString())))
                                        {
                                            lastReading = date;
                                            result.Values.Add(date.ToString(), value);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // If the tag does not exist on the server it will throw an exception -
                        // there doesn't appear to be a way around this so ignore it and mark
                        // the tag as invalid
                        result.IsInvalid = true;
                    }
                }

                resultSet.Add(result);
            }

            return resultSet;
        }
    }
}
