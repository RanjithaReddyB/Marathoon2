using System;
using System.Collections.Generic;
using System.ServiceModel;
using Marathon.Kittyhawk.Services;
using Marathon.Kittyhawk.Services.DataContracts;
using AMS.ConnectionStrings.Services;
using AMS.Core.Models;

namespace Marathon.Kittyhawk.Common
{
    /// <summary>
    /// This static class exposes methods to encapsulate communication with the service bus.
    /// </summary>
    public static class ServiceBusClient
    {
        /// <summary>
        /// Publish bulk transfer records to the service bus.
        /// </summary>
        /// <param name="bulkTransfers">Bulk transfers to publish</param>
        /// <param name="environment">Environment</param>
        /// <param name="URI">Service bus URI</param>
        /// <returns>Updated bulk transfers</returns>
        public static List<BulkTransfer> PublishBulkTransfersToServiceBus(
            List<BulkTransfer> bulkTransfers, string environment, string URI)
        {
            if (environment != EnvironmentType.Local)
            {
                BulkTransferBus.KHBulkTrans_Async_OutClient serviceBus = null;
                bool error = true;

                try
                {
                    serviceBus = new BulkTransferBus.KHBulkTrans_Async_OutClient();
                    serviceBus.Endpoint.Address = new EndpointAddress(URI);

                    ProxyUser user = new ConnStringService().GetProxyUser($"ServiceAccountWithoutDomain-{Environments.Environment}");
                    serviceBus.ClientCredentials.UserName.UserName = user.Username;
                    serviceBus.ClientCredentials.UserName.Password = user.Password;

                    serviceBus.KHBulkTrans_Async_Out(bulkTransfers);

                    // Mark each record as published
                    foreach (var bulkTransfer in bulkTransfers)
                    {
                        bulkTransfer.IsPublished = true;
                    }

                    serviceBus.Close();
                    error = false;
                }
                catch (Exception)
                {
                    // If the operation fails, mark these as unpublished so it retries later
                    foreach (var bulkTransfer in bulkTransfers)
                    {
                        bulkTransfer.IsPublished = false;
                    }

                    error = true;
                    throw;
                }
                finally
                {
                    if (error)
                    {
                        serviceBus.Abort();
                    }
                }
            }
            else
            {
                // If we're ignoring the bus, then mark as published
                foreach (var bulkTransfer in bulkTransfers)
                {
                    bulkTransfer.IsPublished = true;
                }
            }

            return bulkTransfers;
        }

        /// <summary>
        /// Publish inventory records to the service bus.
        /// </summary>
        /// <param name="inventories">Inventories to publish</param>
        /// <param name="environment">Environment</param>
        /// <param name="URI">Service bus URI</param>
        /// <returns>Updated inventories</returns>
        public static List<Inventory> PublishInventoriesToServiceBus(
            List<Inventory> inventories, string environment, string URI)
        {
            if (environment != EnvironmentType.Local)
            {
                InventoryBus.KHInventory_Async_OutClient serviceBus = null;
                bool error = true;

                try
                {
                    serviceBus = new InventoryBus.KHInventory_Async_OutClient("HTTP_Port");
                    serviceBus.Endpoint.Address = new EndpointAddress(URI);

                    ProxyUser user = new ConnStringService().GetProxyUser($"ServiceAccountWithoutDomain-{Environments.Environment}");
                    serviceBus.ClientCredentials.UserName.UserName = user.Username;
                    serviceBus.ClientCredentials.UserName.Password = user.Password;

                    serviceBus.KHInventory_Async_Out(inventories);

                    // Mark each record as published
                    foreach (var inventory in inventories)
                    {
                        inventory.IsPublished = true;
                    }

                    serviceBus.Close();
                    error = false;
                }
                catch (Exception)
                {
                    // If the operation fails, mark these as unpublished so it retries later
                    foreach (var inventory in inventories)
                    {
                        inventory.IsPublished = false;
                    }

                    error = true;
                    throw;
                }
                finally
                {
                    if (error)
                    {
                        serviceBus.Abort();
                    }
                }
            }
            else
            {
                // If we're ignoring the bus, then mark as published
                foreach (var inventory in inventories)
                {
                    inventory.IsPublished = true;
                }
            }

            return inventories;
        }

        /// <summary>
        /// Publish IBEX transactions to the bus to be written to a flat file for
        /// KS34/KS35/KS36 to pick up on the mainframe.
        /// </summary>
        /// <param name="transactions">Transactions to publish</param>
        /// <param name="environment">Environment</param>
        /// <param name="URI">Service bus URI</param>
        /// <returns>Updated transactions</returns>
        public static List<IBEXTransaction> PublishIBEXTransactionsToServiceBus(
            List<IBEXTransaction> transactions, string environment, string URI)
        {
            if (environment != EnvironmentType.Local)
            {
                IBEXBus.InventoryReceiptShipment_Async_OutClient serviceBus = null;
                bool error = true;

                try
                {
                    serviceBus = new IBEXBus.InventoryReceiptShipment_Async_OutClient("HTTP_Port");
                    serviceBus.Endpoint.Address = new EndpointAddress(URI);

                    ProxyUser user = new ConnStringService().GetProxyUser($"ServiceAccountWithoutDomain-{Environments.Environment}");
                    serviceBus.ClientCredentials.UserName.UserName = user.Username;
                    serviceBus.ClientCredentials.UserName.Password = user.Password;

                    serviceBus.InventoryReceiptShipment_Async_Out(transactions);

                    // Mark each record as published
                    foreach (var transaction in transactions)
                    {
                        transaction.IsPublished = true;
                    }

                    serviceBus.Close();
                    error = false;
                }
                catch (Exception)
                {
                    // If the operation fails, mark these as unpublished so it retries later
                    foreach (var transaction in transactions)
                    {
                        transaction.IsPublished = false;
                    }

                    error = true;
                    throw;
                }
                finally
                {
                    if (error)
                    {
                        serviceBus.Abort();
                    }
                }
            }
            else
            {
                // If we're ignoring the bus, then mark as published
                foreach (var transaction in transactions)
                {
                    transaction.IsPublished = true;
                }
            }

            return transactions;
        }
    }
}
