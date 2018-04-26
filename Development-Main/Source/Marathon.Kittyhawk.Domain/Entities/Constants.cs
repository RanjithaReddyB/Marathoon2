namespace Marathon.Kittyhawk.Domain.Entities
{
    public static class IntegrationStatus
    {
        public const int Success = 0;
        public const int Failure = 1;
    }

    public static class ActionCode
    {
        public const string Insert = "Insert";
        public const string Update = "Update";
        public const string Delete = "Delete";
        public static string[] Array = new string[3] { Insert, Update, Delete };
    }

    public static class ActivityType
    {
        public const string Scheduled = "Scheduled";
        public const string Queued = "Queued";
        public const string Actual = "Actual";
        public static string[] Array = new string[3] { Scheduled, Queued, Actual };
    }

    public static class ActivityIndicator
    {
        public const string Planned = "Planned";
        public const string Scheduled = "Scheduled";
        public const string InTransit = "In-Transit";
        public const string Actual = "Actual";
        public const string Estimate = "Estimate";
        public static string[] Array = new string[5] { Planned, Scheduled, InTransit, Actual, Estimate };
    }

    public static class ConnectionType
    {
        public const string Database = "Database";
        public const string PI = "PI";
        public const string Spreadsheet = "Spreadsheet";
        public const string FlatFile = "Flat File";
        public const string Mainframe = "Mainframe";
        public const string Service = "Service";
        public static string[] Array = new string[6] { Database, PI, Spreadsheet, FlatFile, Mainframe, Service };
    }

    public static class DataType
    {
        public const string Core = "Core";
        public const string BulkTransfer = "Bulk Transfer";
        public const string Inventory = "Inventory";
        public const string IBEXTransaction = "IBEX Transaction";
        public const string SalesForecast = "Sales Forecast";
        public const string TransactionUpload = "Transaction Upload";
        public static string[] Array = new string[6] { Core, BulkTransfer, Inventory, IBEXTransaction, SalesForecast, TransactionUpload };
    }

    public static class EnvironmentType
    {
        public const string None = "None";
        public const string Local = "Local";
        public const string Development = "Development";
        public const string Test = "Test";
        public const string Production = "Production";
        public static string[] Array = new string[5] { None, Local, Development, Test, Production };
    }

    public static class EventType
    {
        public const string Integration = "Integration";
        public const string Service = "Service";
        public const string Web = "Web";
        public const string Database = "Database";
        public static string[] Array = new string[4] { Integration, Service, Web, Database };
    }

    public static class LoadOrUnload
    {
        public const string Load = "Load";
        public const string Unload = "Unload";
		public const string NA = "Non-Movement";
        public static string[] Array = new string[3] { Load, Unload, NA };
    }

    public static class SaveMode
    {
        public const string Insert = "Insert";
        public const string Update = "Update";
        public const string Delete = "Delete";
        public static string[] Array = new string[3] { Insert, Update, Delete };
    }

    public static class TransportType
    {
        public const string Pipeline = "Pipeline";
        public const string Railcar = "Railcar";
        public const string Truck = "Truck";
        public const string Vessel = "Vessel";
        public const string BookTransfer = "Book Transfer";
        public const string Barge = "Barge";
		public const string TankBlendInTank = "Tank Blend - In Tank";
		public const string TankBlendMovedProduct = "Tank Blend - Moved Product";
		public const string GainIdentifiable = "Gain - Identifiable";
		public const string GainUnidentifiable = "Gain - Unidentifiable";
		public const string LossIdentifiable = "Loss - Identifiable";
		public const string LossUnidentifiable = "Loss - Unidentifiable";
		public const string CompanyUseRefinery = "Company Use - Refinery";
		public const string CompanyUseTerminal = "Company Use - Terminal";
        public const string Flush = "Flush";
        public const string Prover = "Prover";
        public const string Refuel = "Refuel";
        public static string[] Array = new string[14] { Pipeline, Railcar, Truck, Vessel, BookTransfer, Barge, TankBlendInTank, TankBlendMovedProduct,
			GainIdentifiable, GainUnidentifiable, LossIdentifiable, LossUnidentifiable, CompanyUseRefinery, CompanyUseTerminal};
    }

    public static class TransferType
    {
        public const string BulkTransfer = "BulkTransfer";
        public const string Exchange = "Exchange";
        public const string Purchase = "Purchase";
        public const string Supplier = "Supplier";
        public const string SpotPurchase = "SpotPurchase";
        public const string SpotSale = "SpotSale";
        public const string TerminalTransfer = "TerminalTransfer";
        public const string ExchangePurchaseSale = "Exchange/Purchase/Sale";
        public const string Regrade = "Regrade";
		public const string LossGain = "LossGain";
		public const string PLOverShort = "PL OverShort";
        public const string CompanyUse = "CompanyUse";
        public const string Inventory = "Inventory";
        public static string[] Array = new string[9] { BulkTransfer, Exchange, SpotPurchase, SpotSale, ExchangePurchaseSale, Regrade, LossGain, PLOverShort, CompanyUse };
    }

    public static class LocationType
    {
        public const string Terminal3rdParty = "Terminal-3rd Party";
        public const string ExchangePoint = "Exchange Point";
        public const string TerminalMpc = "Terminal-MPC";
        public const string Refinery = "Refinery";
        public const string ThirdPartyRefinery = "3rd Party Refinery";
        public const string RailRack = "Rail Rack";
        public const string RailYard = "Rail Yard";
        public const string InTransit = "In Transit";
        public const string Fleet = "Fleet";
    }

    public static class UnitOfMeasure
    {
        public const string Gallons = "Gallons";
        public const string Barrels = "Barrels";
        public const string Tons = "Tons";
        public const string LongTons = "Long Tons";
        public const string Pounds = "Pounds";
        public const string MMBTU = "MMBTU";
        public const string Feet = "Feet";
        public const string Hours = "Hours";
        public const string Minutes = "Minutes";
        public const string Seconds = "Seconds";
        public static string[] Array = new string[10] { Gallons, Barrels, Tons, LongTons, Pounds, MMBTU, Feet, Hours, Minutes, Seconds };
    }

    public static class VehicleType
    {
        public const string Vessel = "Vessel";
        public const string Barge = "Barge";
        public static string[] Array = new string[2] { Vessel, Barge };

    }

    public static class TransactionUploadType
    {
        public const string Source = "Transaction Upload";
        public const string Destination = "Kittyhawk";
        public const string BusinnessAssociate = "Business Associate";
        public const string Location = "Location";
        public const string Product = "Product";
        public const string Container = "Container";
        public const string Transport = "Transport";        
    }

    public static class XRefType
    {
        public const string Facility = "Facility";
        public const string Origin = "Origin";
        public const string Destination = "Destination";
        public const string Customer = "Customer";
        public const string Supplier = "Supplier";
        public const string Carrier = "Carrier";
		public const string IssuedBy = "Issued By";
        public const string Product = "Product";
        public const string ComponentProduct = "ComponentProduct";
        public const string EndProduct = "EndProduct";
    }

    public static class NServiceBusPersistanceConnectionStrings
    {
        public const string Prod = "NServiceBus/PersistenceProd";
        public const string Test = "NServiceBus/PersistenceTest";
        public const string Dev = "NServiceBus/PersistenceDev";
        public const string Local = "NServiceBus/PersistenceLocal";        
    }

    public static class NServiceBusTransportConnectionStrings
    {
        public const string Prod = "NServiceBus/TransportProd";
        public const string Test = "NServiceBus/TransportTest";
        public const string Dev = "NServiceBus/TransportDev";
        public const string Local = "NServiceBus/TransportLocal";
    }

    public static class NServiceBusProperties
    {        
        public const string Schema = "transport";
        public const string Dialect = "NHibernate.Dialect.MsSql2012Dialect";
    }

    public static class NServiceBusEndpoints
    {
        public const string MessagingServerEndpointName = "Marathon.Kittyhawk.Messaging.Server";
        public const string WebApiEndpointName = "Kittyhawk.WebApi";
    }

    public static class XrefClientConfiguration
    {
        public const string EndpointConfigurationName = "BasicHttpBinding_IXRefService.cs";
    }

    public static class TransactionBuildType
    {
        public const string Inventory = "I - Inventory";
        public const string Processing = "P - Processing";
        public const string Sales = "S - Sales";
    }

    public static class TerminalDownloadClientConfiguration
    {
        public const string EndpointConfigurationName = "BasicHttpBinding_ITerminalDownloadAssociationService";
    }

    public static class AutoMatchStatus
    {
        public const string AutoMatch = "Auto Match";
        public const string OrderMatch = "Order Match";
        public const string DoNoMatch = "Do Not Match";
        public static string[] Array = new string[3] { AutoMatch, OrderMatch, DoNoMatch };
    }

    public static class DealType
    {
        public const string Blending = "Blending";
        public const string Exchange = "Exchange";
        public const string Processing = "Processing";
        public const string Truck = "Truck";
        public const string Sale = "Sale";
    }

    public static class DealStatus
    {
        public const string Active = "Active";
        public const string Inactive = "Inactive";
    }

    public static class SupplyDemand
    {
        public const string Receipt = "Receipt";
        public const string Delivery = "Delivery";
    }

    public static class ComType
    {
        public static string LPG = "L";
        public static string Asphalt = "A";
        public static string Specialties = "S";
    }
}
