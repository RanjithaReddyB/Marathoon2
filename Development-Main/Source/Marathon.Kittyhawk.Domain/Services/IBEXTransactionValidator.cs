using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class that contains validation logic for IBEX transactions.
    /// </summary>
    public static class IBEXTransactionValidator
    {
        /// <summary>
        /// Helper method that contains the logic to determine if a particular transaction
        /// is in an error state, and if so, what its error message should be.
        /// </summary>
        /// <param name="transaction">Transaction</param>
        /// <returns>Error message</returns>
        public static string GetErrorMessage(IBEXTransaction transaction)
        {
            var controlCodes = new List<string> { "04", "07", "10", "11", "12", "27", "31", "32", "34", "37", "40", "41", "42", "82", "83", "84", "85" };
            var refineries = new List<string> { "1620", "1621", "1629", "1636", "1682", "1694", "2162" };

            if (transaction.Com == null)
            {
                return "Com missing for movement " + transaction.ExstarsTicketNo;
            }

            if (transaction.DealType.Contains("Sale") ||
                (transaction.DealType.Contains("Exchange") && transaction.ShipRcpt == "SHIP"))
            {
                if (transaction.RptLoc == null)
                {
                    if ((transaction.MovementDocType == null ||
                        !transaction.MovementDocType.Contains("Refinery")) &&
                        refineries.Contains(transaction.Origin))
                    {
                        return "Xref missing for " + transaction.Destination;
                    }
                    else
                    {
                        return "Xref missing for " + transaction.Origin;
                    }
                }
                else if (transaction.RefLoc == null && transaction.DealType.Contains("Exchange"))
                {
                    return "Xref missing for " + transaction.Destination + "-" + transaction.DealNo;
                }
            }
            else if (transaction.DealType.Contains("Purchase") ||
                (transaction.DealType.Contains("Exchange") && transaction.ShipRcpt == "RCPT"))
            {
                if (transaction.RptLoc == null)
                {
                    if ((transaction.MovementDocType == null ||
                        !transaction.MovementDocType.Contains("Refinery")) &&
                        refineries.Contains(transaction.Destination))
                    {
                        return "Xref missing for " + transaction.Origin;
                    }
                    else
                    {
                        return "Xref missing for " + transaction.Destination;
                    }
                }
                else if (transaction.RefLoc == null)
                {
                    return "Xref missing for " + transaction.Destination + "-" + transaction.DealNo;
                }
            }
            else if (transaction.ControlCode == "85")
            {
                if (transaction.RptLoc == null)
                {
                    return "Xref missing for " + transaction.Origin;
                }
            }
            else if (controlCodes.Contains(transaction.ControlCode))
            {
                if (transaction.RptLoc == null)
                {
                    return "Xref missing for " + transaction.Destination;
                }
            }
            else
            {
                if (transaction.ShipRcpt == "SHIP")
                {
                    if (transaction.IsTransportation == "Y")
                    {
                        if (transaction.RptLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin + "-" +
                                transaction.Destination + "-" + transaction.DealNo;
                        }
                        else if (transaction.RefLoc == null)
                        {
                            return "Xref missing for " + transaction.Destination;
                        }
                    }
                    else
                    {
                        if (transaction.RptLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin;
                        }
                        else if (transaction.RefLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin + "-" +
                                transaction.Destination + "-" + transaction.DealNo;
                        }
                    }
                }
                else
                {
                    if (transaction.IsTransportation == "Y")
                    {
                        if (transaction.RptLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin + "-" +
                                transaction.Destination + "-" + transaction.DealNo;
                        }
                        else if (transaction.RefLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin;
                        }
                    }
                    else
                    {
                        if (transaction.RptLoc == null)
                        {
                            return "Xref missing for " + transaction.Destination;
                        }
                        else if (transaction.RefLoc == null)
                        {
                            return "Xref missing for " + transaction.Origin + "-" +
                                transaction.Destination + "-" + transaction.DealNo;
                        }
                    }
                }
            }

            return null;
        }
    }
}
