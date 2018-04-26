namespace Marathon.Kittyhawk.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        DataSourceID = c.Guid(nullable: false),
                        ActivityType = c.String(nullable: false, maxLength: 100),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Duration = c.Double(),
                        DurationUnit = c.String(maxLength: 100),
                        RecordsProcessed = c.Int(),
                        DirtyRecords = c.Int(),
                        Marker = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .Index(t => t.DataSourceID);
            
            CreateTable(
                "dbo.DataSource",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        System = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        DataType = c.String(nullable: false, maxLength: 100),
                        ConnectionType = c.String(nullable: false, maxLength: 100),
                        ConnectionDetail = c.String(nullable: false),
                        Schedule = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BulkTransferHistory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        DataSourceID = c.Guid(nullable: false),
                        IsDirty = c.Boolean(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        IgnoreErrors = c.Boolean(nullable: false),
                        ErrorStatus = c.String(nullable: false),
                        ActionCode = c.String(nullable: false, maxLength: 100),
                        ActivityIndicator = c.String(nullable: false, maxLength: 100),
                        LoadOrUnload = c.String(nullable: false, maxLength: 100),
                        BatchIdentifier = c.String(maxLength: 100),
                        TicketNumber = c.String(maxLength: 100),
                        ShortTicketNumber = c.String(maxLength: 100),
                        FacilityID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        ContainerID = c.Guid(),
                        ProductID = c.Guid(),
                        CustomerID = c.Guid(),
                        SupplierID = c.Guid(),
                        ShipperID = c.Guid(),
                        CarrierID = c.Guid(),
                        TransportID = c.Guid(),
                        VehicleID = c.Guid(),
                        OriginFacilityCode = c.String(maxLength: 100),
                        OriginContainerCode = c.String(maxLength: 100),
                        OriginProductCode = c.String(maxLength: 100),
                        DestinationFacilityCode = c.String(maxLength: 100),
                        DestinationContainerCode = c.String(maxLength: 100),
                        DestinationProductCode = c.String(maxLength: 100),
                        CustomerCode = c.String(maxLength: 100),
                        SupplierCode = c.String(maxLength: 100),
                        ShipperCode = c.String(maxLength: 100),
                        CarrierCode = c.String(maxLength: 100),
                        TransportCode = c.String(maxLength: 100),
                        VehicleCode = c.String(maxLength: 100),
                        CountryCode = c.String(maxLength: 100),
                        TransportType = c.String(maxLength: 100),
                        TransferStart = c.DateTime(),
                        TransferEnd = c.DateTime(),
                        ETA = c.DateTime(),
                        ProgressLandmark = c.String(maxLength: 100),
                        ProgressLandmarkTimestamp = c.DateTime(),
                        ScheduledQuantity = c.Double(),
                        ScheduledQuantityUnit = c.String(maxLength: 100),
                        GrossQuantity = c.Double(),
                        GrossQuantityUnit = c.String(maxLength: 100),
                        NetQuantity = c.Double(),
                        NetQuantityUnit = c.String(maxLength: 100),
                        Gravity = c.Double(),
                        Temperature = c.Double(),
                        RVP = c.Double(),
                        TransferType = c.String(maxLength: 100),
                        ContractNumber = c.String(maxLength: 100),
                        CarStatus = c.String(maxLength: 100),
                        IsThirdParty = c.Boolean(),
                        IsFreeRunner = c.Boolean(),
                        IsSupplierShipment = c.Boolean(),
                        Comments = c.String(),
                        SourceID = c.String(maxLength: 100),
                        SourceDate = c.DateTime(),
                        SourceRecord = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CarrierID)
                .ForeignKey("dbo.Container", t => t.ContainerID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CustomerID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.FacilityID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ShipperID)
                .ForeignKey("dbo.BusinessAssociate", t => t.SupplierID)
                .ForeignKey("dbo.Transport", t => t.TransportID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => t.DataSourceID)
                .Index(t => t.FacilityID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.ContainerID)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.SupplierID)
                .Index(t => t.ShipperID)
                .Index(t => t.CarrierID)
                .Index(t => t.TransportID)
                .Index(t => t.VehicleID);
            
            CreateTable(
                "dbo.BusinessAssociate",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        BAKey = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Abbreviation = c.String(nullable: false, maxLength: 50),
                        ClassOfTrade = c.String(nullable: false, maxLength: 80),
                        NetOutCustomer = c.String(nullable: false, maxLength: 1, fixedLength: true),
                        FederalTax = c.String(maxLength: 50),
                        SCAC = c.String(maxLength: 50),
                        LegacyID = c.String(maxLength: 50),
                        SAPVendor = c.String(maxLength: 50),
                        SAPCustomer = c.String(maxLength: 50),
                        SAPCompany = c.String(maxLength: 50),
                        ContactID = c.Int(),
                        ContactLocationName = c.String(maxLength: 150),
                        ContactFirstName = c.String(maxLength: 50),
                        ContactMiddleInitial = c.String(maxLength: 50),
                        ContactLastName = c.String(maxLength: 50),
                        ContactTitle = c.String(maxLength: 50),
                        ContactDepartment = c.String(maxLength: 50),
                        ContactPhone = c.String(maxLength: 50),
                        ContactFax = c.String(maxLength: 50),
                        ContactPager = c.String(maxLength: 50),
                        ContactEmail = c.String(maxLength: 50),
                        ContactPostalRoute = c.String(maxLength: 50),
                        ContactBirthDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Container",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        FacilityID = c.Guid(nullable: false),
                        ProductID = c.Guid(nullable: false),
                        Capacity = c.Double(),
                        CapacityUnit = c.String(maxLength: 100),
                        Bottom = c.Double(),
                        BottomUnit = c.String(maxLength: 100),
                        OutOfService = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.FacilityID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.FacilityID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        LocationKey = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Abbreviation = c.String(nullable: false, maxLength: 120),
                        Type = c.String(nullable: false, maxLength: 80),
                        City = c.String(maxLength: 50),
                        StateOrProvince = c.String(maxLength: 50),
                        Country = c.String(maxLength: 50),
                        SAPProfitCenter4500 = c.String(maxLength: 50),
                        SAPProfitCenter4502 = c.String(maxLength: 50),
                        SAPProfitCenter4504 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProductKey = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 50),
                        Gravity = c.Double(nullable: false),
                        Energy = c.Double(nullable: false),
                        Density = c.Double(nullable: false),
                        Commodity = c.String(nullable: false, maxLength: 80),
                        SubGroup = c.String(maxLength: 80),
                        SweetSour = c.String(maxLength: 80),
                        SAPMaterialRaw = c.String(maxLength: 50),
                        SAPMaterialRefined = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        TransportType = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        VehicleKey = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 80),
                        Type = c.String(nullable: false, maxLength: 20),
                        MaxQuantity = c.Double(nullable: false),
                        YearBuilt = c.Int(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BulkTransfer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        DataSourceID = c.Guid(nullable: false),
                        IsDirty = c.Boolean(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        IgnoreErrors = c.Boolean(nullable: false),
                        ErrorStatus = c.String(nullable: false),
                        ActionCode = c.String(nullable: false, maxLength: 100),
                        ActivityIndicator = c.String(nullable: false, maxLength: 100),
                        LoadOrUnload = c.String(nullable: false, maxLength: 100),
                        BatchIdentifier = c.String(maxLength: 100),
                        TicketNumber = c.String(maxLength: 100),
                        ShortTicketNumber = c.String(maxLength: 100),
                        FacilityID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        ContainerID = c.Guid(),
                        ProductID = c.Guid(),
                        CustomerID = c.Guid(),
                        SupplierID = c.Guid(),
                        ShipperID = c.Guid(),
                        CarrierID = c.Guid(),
                        TransportID = c.Guid(),
                        VehicleID = c.Guid(),
                        OriginFacilityCode = c.String(maxLength: 100),
                        OriginContainerCode = c.String(maxLength: 100),
                        OriginProductCode = c.String(maxLength: 100),
                        DestinationFacilityCode = c.String(maxLength: 100),
                        DestinationContainerCode = c.String(maxLength: 100),
                        DestinationProductCode = c.String(maxLength: 100),
                        CustomerCode = c.String(maxLength: 100),
                        SupplierCode = c.String(maxLength: 100),
                        ShipperCode = c.String(maxLength: 100),
                        CarrierCode = c.String(maxLength: 100),
                        TransportCode = c.String(maxLength: 100),
                        VehicleCode = c.String(maxLength: 100),
                        CountryCode = c.String(maxLength: 100),
                        TransportType = c.String(maxLength: 100),
                        TransferStart = c.DateTime(),
                        TransferEnd = c.DateTime(),
                        ETA = c.DateTime(),
                        ProgressLandmark = c.String(maxLength: 100),
                        ProgressLandmarkTimestamp = c.DateTime(),
                        ScheduledQuantity = c.Double(),
                        ScheduledQuantityUnit = c.String(maxLength: 100),
                        GrossQuantity = c.Double(),
                        GrossQuantityUnit = c.String(maxLength: 100),
                        NetQuantity = c.Double(),
                        NetQuantityUnit = c.String(maxLength: 100),
                        Gravity = c.Double(),
                        Temperature = c.Double(),
                        RVP = c.Double(),
                        TransferType = c.String(maxLength: 100),
                        ContractNumber = c.String(maxLength: 100),
                        CarStatus = c.String(maxLength: 100),
                        IsThirdParty = c.Boolean(),
                        IsFreeRunner = c.Boolean(),
                        IsSupplierShipment = c.Boolean(),
                        Comments = c.String(),
                        SourceID = c.String(maxLength: 100),
                        SourceDate = c.DateTime(),
                        SourceRecord = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CarrierID)
                .ForeignKey("dbo.Container", t => t.ContainerID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CustomerID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.FacilityID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ShipperID)
                .ForeignKey("dbo.BusinessAssociate", t => t.SupplierID)
                .ForeignKey("dbo.Transport", t => t.TransportID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => t.DataSourceID)
                .Index(t => t.FacilityID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.ContainerID)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.SupplierID)
                .Index(t => t.ShipperID)
                .Index(t => t.CarrierID)
                .Index(t => t.TransportID)
                .Index(t => t.VehicleID);
            
            CreateTable(
                "dbo.Error",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100),
                        EventType = c.String(nullable: false, maxLength: 100),
                        EventDetail = c.String(),
                        Description = c.String(),
                        StackTrace = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IBEXTransactionHistory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        IsPublished = c.Boolean(nullable: false),
                        DataType = c.String(nullable: false, maxLength: 20),
                        CntryCode = c.String(maxLength: 20),
                        CoAbrv = c.String(maxLength: 20),
                        Com = c.String(maxLength: 20),
                        Company = c.String(maxLength: 20),
                        ControlCode = c.String(maxLength: 20),
                        CrudeCode = c.String(maxLength: 20),
                        CustNo = c.String(maxLength: 20),
                        ExchContractNo = c.String(maxLength: 20),
                        Gravity = c.Double(nullable: false),
                        GrossQty = c.Double(nullable: false),
                        GrossQtyGal = c.Double(nullable: false),
                        InvoiceNo = c.String(maxLength: 20),
                        LbsGalConv = c.Double(nullable: false),
                        MarathonOrderNo = c.String(maxLength: 20),
                        NetQty = c.Double(nullable: false),
                        NetQtyGal = c.Double(nullable: false),
                        PlBatch = c.String(maxLength: 20),
                        RecipeCode = c.String(maxLength: 20),
                        RecNo = c.String(maxLength: 20),
                        ReferenceCommodity = c.String(maxLength: 20),
                        RefineryBusMo = c.String(maxLength: 20),
                        RefLoc = c.String(maxLength: 20),
                        RptDate = c.String(maxLength: 20),
                        RptLoc = c.String(maxLength: 20),
                        RRCarTruck = c.String(maxLength: 20),
                        SCAC = c.String(maxLength: 20),
                        ShipDate = c.String(maxLength: 20),
                        TicketNo = c.String(maxLength: 20),
                        TransOrigin = c.String(maxLength: 20),
                        TransportMode = c.String(maxLength: 20),
                        TransportRqst = c.String(maxLength: 20),
                        UMEA = c.String(maxLength: 20),
                        DestState = c.String(maxLength: 20),
                        ExchCustNo = c.String(maxLength: 20),
                        FreightTerms = c.String(maxLength: 20),
                        TypeLossGain = c.String(maxLength: 20),
                        TimeIn = c.String(maxLength: 20),
                        TimeOut = c.String(maxLength: 20),
                        ExstarsTicketNo = c.String(maxLength: 50),
                        TankNo = c.String(maxLength: 20),
                        TermMeterNo = c.String(maxLength: 20),
                        TypeCoUse = c.String(maxLength: 20),
                        ShipRcpt = c.String(maxLength: 20),
                        IsSales = c.String(maxLength: 20),
                        IsTransportation = c.String(maxLength: 20),
                        Origin = c.String(maxLength: 20),
                        Destination = c.String(maxLength: 20),
                        DealNo = c.String(maxLength: 20),
                        DealType = c.String(maxLength: 20),
                        Carrier = c.String(maxLength: 20),
                        Product = c.String(maxLength: 20),
                        MovementDocNo = c.String(maxLength: 20),
                        MovementTransNo = c.String(maxLength: 20),
                        MovementDocType = c.String(maxLength: 100),
                        CreatedByUser = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IBEXTransaction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        IsPublished = c.Boolean(nullable: false),
                        DataType = c.String(nullable: false, maxLength: 20),
                        CntryCode = c.String(maxLength: 20),
                        CoAbrv = c.String(maxLength: 20),
                        Com = c.String(maxLength: 20),
                        Company = c.String(maxLength: 20),
                        ControlCode = c.String(maxLength: 20),
                        CrudeCode = c.String(maxLength: 20),
                        CustNo = c.String(maxLength: 20),
                        ExchContractNo = c.String(maxLength: 20),
                        Gravity = c.Double(nullable: false),
                        GrossQty = c.Double(nullable: false),
                        GrossQtyGal = c.Double(nullable: false),
                        InvoiceNo = c.String(maxLength: 20),
                        LbsGalConv = c.Double(nullable: false),
                        MarathonOrderNo = c.String(maxLength: 20),
                        NetQty = c.Double(nullable: false),
                        NetQtyGal = c.Double(nullable: false),
                        PlBatch = c.String(maxLength: 20),
                        RecipeCode = c.String(maxLength: 20),
                        RecNo = c.String(maxLength: 20),
                        ReferenceCommodity = c.String(maxLength: 20),
                        RefineryBusMo = c.String(maxLength: 20),
                        RefLoc = c.String(maxLength: 20),
                        RptDate = c.String(maxLength: 20),
                        RptLoc = c.String(maxLength: 20),
                        RRCarTruck = c.String(maxLength: 20),
                        SCAC = c.String(maxLength: 20),
                        ShipDate = c.String(maxLength: 20),
                        TicketNo = c.String(maxLength: 20),
                        TransOrigin = c.String(maxLength: 20),
                        TransportMode = c.String(maxLength: 20),
                        TransportRqst = c.String(maxLength: 20),
                        UMEA = c.String(maxLength: 20),
                        DestState = c.String(maxLength: 20),
                        ExchCustNo = c.String(maxLength: 20),
                        FreightTerms = c.String(maxLength: 20),
                        TypeLossGain = c.String(maxLength: 20),
                        TimeIn = c.String(maxLength: 20),
                        TimeOut = c.String(maxLength: 20),
                        ExstarsTicketNo = c.String(maxLength: 50),
                        TankNo = c.String(maxLength: 20),
                        TermMeterNo = c.String(maxLength: 20),
                        TypeCoUse = c.String(maxLength: 20),
                        ShipRcpt = c.String(maxLength: 20),
                        IsSales = c.String(maxLength: 20),
                        IsTransportation = c.String(maxLength: 20),
                        Origin = c.String(maxLength: 20),
                        Destination = c.String(maxLength: 20),
                        DealNo = c.String(maxLength: 20),
                        DealType = c.String(maxLength: 20),
                        Carrier = c.String(maxLength: 20),
                        Product = c.String(maxLength: 20),
                        MovementDocNo = c.String(maxLength: 20),
                        MovementTransNo = c.String(maxLength: 20),
                        MovementDocType = c.String(maxLength: 100),
                        CreatedByUser = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InventoryHistory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        DataSourceID = c.Guid(nullable: false),
                        IsDirty = c.Boolean(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        IgnoreErrors = c.Boolean(nullable: false),
                        ErrorStatus = c.String(nullable: false),
                        FacilityID = c.Guid(),
                        ContainerID = c.Guid(),
                        ProductID = c.Guid(),
                        CompanyID = c.Guid(),
                        FacilityCode = c.String(maxLength: 100),
                        ContainerCode = c.String(maxLength: 100),
                        ProductCode = c.String(maxLength: 100),
                        CompanyCode = c.String(maxLength: 100),
                        MeasurementDateTime = c.DateTime(),
                        GrossQuantity = c.Double(),
                        GrossQuantityUnit = c.String(maxLength: 100),
                        NetQuantity = c.Double(),
                        NetQuantityUnit = c.String(maxLength: 100),
                        Temperature = c.Double(),
                        Gravity = c.Double(),
                        InventoryLevel = c.Double(),
                        RemainingFill = c.Double(),
                        RemainingFillUnit = c.String(maxLength: 100),
                        AvailableQuantity = c.Double(),
                        AvailableQuantityUnit = c.String(maxLength: 100),
                        Flow = c.Double(),
                        FlowUnit = c.String(maxLength: 100),
                        FlowTimeSpan = c.Double(),
                        FlowTimeSpanUnit = c.String(maxLength: 100),
                        RVP = c.Double(),
                        Ethanol = c.Double(),
                        IsThirdParty = c.Boolean(),
                        SourceID = c.String(maxLength: 100),
                        SourceDate = c.DateTime(),
                        SourceRecord = c.String(),
                        OOSIndicator = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CompanyID)
                .ForeignKey("dbo.Container", t => t.ContainerID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .ForeignKey("dbo.Location", t => t.FacilityID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.DataSourceID)
                .Index(t => t.FacilityID)
                .Index(t => t.ContainerID)
                .Index(t => t.ProductID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        DataSourceID = c.Guid(nullable: false),
                        IsDirty = c.Boolean(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        IgnoreErrors = c.Boolean(nullable: false),
                        ErrorStatus = c.String(nullable: false),
                        FacilityID = c.Guid(),
                        ContainerID = c.Guid(),
                        ProductID = c.Guid(),
                        CompanyID = c.Guid(),
                        FacilityCode = c.String(maxLength: 100),
                        ContainerCode = c.String(maxLength: 100),
                        ProductCode = c.String(maxLength: 100),
                        CompanyCode = c.String(maxLength: 100),
                        MeasurementDateTime = c.DateTime(),
                        GrossQuantity = c.Double(),
                        GrossQuantityUnit = c.String(maxLength: 100),
                        NetQuantity = c.Double(),
                        NetQuantityUnit = c.String(maxLength: 100),
                        Temperature = c.Double(),
                        Gravity = c.Double(),
                        InventoryLevel = c.Double(),
                        RemainingFill = c.Double(),
                        RemainingFillUnit = c.String(maxLength: 100),
                        AvailableQuantity = c.Double(),
                        AvailableQuantityUnit = c.String(maxLength: 100),
                        Flow = c.Double(),
                        FlowUnit = c.String(maxLength: 100),
                        FlowTimeSpan = c.Double(),
                        FlowTimeSpanUnit = c.String(maxLength: 100),
                        RVP = c.Double(),
                        Ethanol = c.Double(),
                        IsThirdParty = c.Boolean(),
                        SourceID = c.String(maxLength: 100),
                        SourceDate = c.DateTime(),
                        SourceRecord = c.String(),
                        OOSIndicator = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CompanyID)
                .ForeignKey("dbo.Container", t => t.ContainerID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .ForeignKey("dbo.Location", t => t.FacilityID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.DataSourceID)
                .Index(t => t.FacilityID)
                .Index(t => t.ContainerID)
                .Index(t => t.ProductID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.InventoryTagGroup",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        DataSourceID = c.Guid(nullable: false),
                        Container = c.String(maxLength: 20),
                        CommodityCode = c.String(nullable: false, maxLength: 20),
                        FlowRate = c.String(maxLength: 20),
                        APIGravity = c.String(maxLength: 20),
                        TotalLevel = c.String(maxLength: 20),
                        BSWLevel = c.String(maxLength: 20),
                        Temperature = c.String(maxLength: 20),
                        GrossVolume = c.String(maxLength: 20),
                        NetVolume = c.String(maxLength: 20),
                        VolumeTotal = c.String(maxLength: 20),
                        OOS = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DataSource", t => t.DataSourceID)
                .Index(t => t.DataSourceID);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100),
                        EventType = c.String(nullable: false, maxLength: 100),
                        EventDetail = c.String(maxLength: 100),
                        Description = c.String(),
                        Metric = c.Double(),
                        MetricDescription = c.String(maxLength: 100),
                        MetricUnit = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RefineryInventoryError",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false, maxLength: 100),
                        Refinery = c.String(nullable: false, maxLength: 100),
                        Tank = c.String(nullable: false, maxLength: 100),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        FeedsOutOfDate = c.Boolean(nullable: false),
                        BulkTransferErrors = c.Boolean(nullable: false),
                        InventoryErrors = c.Boolean(nullable: false),
                        IBEXTransactionErrors = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PositionGroup",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        PositionGroupKey = c.Int(nullable: false),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        Depth = c.Int(),
                        TopLevelID = c.Int(),
                        BottomLevelID = c.Int(),
                        Level1ID = c.Int(),
                        Level2ID = c.Int(),
                        Level3ID = c.Int(),
                        Level4ID = c.Int(),
                        Level5ID = c.Int(),
                        TopLevelName = c.String(),
                        BottomLevelName = c.String(),
                        Level1Name = c.String(),
                        Level2Name = c.String(),
                        Level3Name = c.String(),
                        Level4Name = c.String(),
                        Level5Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID);
            
            CreateTable(
                "dbo.Deal",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        DealHeaderKey = c.Int(nullable: false),
                        DealDetailKey = c.Int(nullable: false),
                        TheirCompanyID = c.Guid(),
                        DivisionID = c.Guid(),
                        CarrierID = c.Guid(),
                        ShipperID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        VehicleID = c.Guid(),
                        DealNumber = c.String(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                        RevisionDate = c.DateTime(),
                        DetailFromDate = c.DateTime(),
                        DetailToDate = c.DateTime(),
                        DetailCreatedDate = c.DateTime(),
                        DetailRevisionDate = c.DateTime(),
                        TheirContact = c.String(),
                        InternalContact = c.String(),
                        Status = c.String(),
                        DetailStatus = c.String(),
                        DealType = c.String(),
                        DealTemplate = c.String(),
                        TransportMethod = c.String(),
                        DealTerm = c.String(),
                        SupplyDemand = c.String(),
                        Direction = c.String(),
                        SubType = c.String(),
                        DomesticForeign = c.String(),
                        IsTransportation = c.String(),
                        IsPhysical = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        QuantityFrequency = c.String(),
                        SchedulingQuantityTerm = c.String(),
                        Description = c.String(),
                        Strategy = c.String(),
                        PaymentTerms = c.String(),
                        GeneralTerms = c.String(),
                        CreditType = c.String(),
                        PandC = c.String(),
                        TaxClass = c.String(),
                        DeliveryTerm = c.String(),
                        TitleTransfer = c.String(),
                        Measurement = c.String(),
                        TransportProvider = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CarrierID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.BusinessAssociate", t => t.DivisionID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ShipperID)
                .ForeignKey("dbo.BusinessAssociate", t => t.TheirCompanyID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => t.TheirCompanyID)
                .Index(t => t.DivisionID)
                .Index(t => t.CarrierID)
                .Index(t => t.ShipperID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.VehicleID);
            
            CreateTable(
                "dbo.MovementPlan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        RoutePlanHeaderKey = c.Int(nullable: false),
                        OriginProductID = c.Guid(),
                        DestinationProductID = c.Guid(),
                        OriginLocationID = c.Guid(),
                        DestinationLocationID = c.Guid(),
                        Leg1CarrierID = c.Guid(),
                        Leg2CarrierID = c.Guid(),
                        Leg3CarrierID = c.Guid(),
                        Leg4CarrierID = c.Guid(),
                        Leg5CarrierID = c.Guid(),
                        Leg1OriginDealID = c.Guid(),
                        Leg1DestinationDealID = c.Guid(),
                        Leg2OriginDealID = c.Guid(),
                        Leg2DestinationDealID = c.Guid(),
                        Leg3OriginDealID = c.Guid(),
                        Leg3DestinationDealID = c.Guid(),
                        Leg4OriginDealID = c.Guid(),
                        Leg4DestinationDealID = c.Guid(),
                        Leg5OriginDealID = c.Guid(),
                        Leg5DestinationDealID = c.Guid(),
                        Name = c.String(),
                        Type = c.String(),
                        Status = c.String(),
                        NumberOfLegs = c.Int(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        Leg1TransportType = c.String(),
                        Leg2TransportType = c.String(),
                        Leg3TransportType = c.String(),
                        Leg4TransportType = c.String(),
                        Leg5TransportType = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.DestinationLocationID)
                .ForeignKey("dbo.Product", t => t.DestinationProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.Leg1CarrierID)
                .ForeignKey("dbo.Deal", t => t.Leg1DestinationDealID)
                .ForeignKey("dbo.Deal", t => t.Leg1OriginDealID)
                .ForeignKey("dbo.BusinessAssociate", t => t.Leg2CarrierID)
                .ForeignKey("dbo.Deal", t => t.Leg2DestinationDealID)
                .ForeignKey("dbo.Deal", t => t.Leg2OriginDealID)
                .ForeignKey("dbo.BusinessAssociate", t => t.Leg3CarrierID)
                .ForeignKey("dbo.Deal", t => t.Leg3DestinationDealID)
                .ForeignKey("dbo.Deal", t => t.Leg3OriginDealID)
                .ForeignKey("dbo.BusinessAssociate", t => t.Leg4CarrierID)
                .ForeignKey("dbo.Deal", t => t.Leg4DestinationDealID)
                .ForeignKey("dbo.Deal", t => t.Leg4OriginDealID)
                .ForeignKey("dbo.BusinessAssociate", t => t.Leg5CarrierID)
                .ForeignKey("dbo.Deal", t => t.Leg5DestinationDealID)
                .ForeignKey("dbo.Deal", t => t.Leg5OriginDealID)
                .ForeignKey("dbo.Location", t => t.OriginLocationID)
                .ForeignKey("dbo.Product", t => t.OriginProductID)
                .Index(t => t.OriginProductID)
                .Index(t => t.DestinationProductID)
                .Index(t => t.OriginLocationID)
                .Index(t => t.DestinationLocationID)
                .Index(t => t.Leg1CarrierID)
                .Index(t => t.Leg2CarrierID)
                .Index(t => t.Leg3CarrierID)
                .Index(t => t.Leg4CarrierID)
                .Index(t => t.Leg5CarrierID)
                .Index(t => t.Leg1OriginDealID)
                .Index(t => t.Leg1DestinationDealID)
                .Index(t => t.Leg2OriginDealID)
                .Index(t => t.Leg2DestinationDealID)
                .Index(t => t.Leg3OriginDealID)
                .Index(t => t.Leg3DestinationDealID)
                .Index(t => t.Leg4OriginDealID)
                .Index(t => t.Leg4DestinationDealID)
                .Index(t => t.Leg5OriginDealID)
                .Index(t => t.Leg5DestinationDealID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        PlannedMovementKey = c.Int(nullable: false),
                        ProductID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        FinalDestinationID = c.Guid(),
                        VehicleID = c.Guid(),
                        MovementPlanID = c.Guid(),
                        OrderNumber = c.String(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Status = c.String(),
                        RollType = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        BatchName = c.String(),
                        PlannedTransport = c.String(),
                        Scheduler = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.FinalDestinationID)
                .ForeignKey("dbo.MovementPlan", t => t.MovementPlanID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => t.ProductID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.FinalDestinationID)
                .Index(t => t.VehicleID)
                .Index(t => t.MovementPlanID);
            
            CreateTable(
                "dbo.Transfer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        PlannedTransferKey = c.Int(nullable: false),
                        PlannedMovementKey = c.Int(),
                        CarrierID = c.Guid(),
                        ConsigneeID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        DealID = c.Guid(),
                        OrderID = c.Guid(),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        ChangedDate = c.DateTime(),
                        EstimatedStartDate = c.DateTime(),
                        EstimatedEndDate = c.DateTime(),
                        SchedulingPeriod = c.String(),
                        Status = c.String(),
                        CustomStatus = c.String(),
                        SupplyDemand = c.String(),
                        TransportMethod = c.String(),
                        SequenceNumber = c.Int(),
                        TotalQuantity = c.Double(),
                        ActualQuantity = c.Double(),
                        RemainingQuantity = c.Double(),
                        QuantityUnit = c.String(),
                        TotalWeight = c.Double(),
                        ActualWeight = c.Double(),
                        WeightUnit = c.String(),
                        Price = c.Double(),
                        Strategy = c.String(),
                        Currency = c.String(),
                        IsObligationTransfer = c.String(),
                        NetNominate = c.String(),
                        InternallyVerified = c.String(),
                        ExternallyVerified = c.String(),
                        ExcludeFromNomination = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CarrierID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ConsigneeID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Order", t => t.OrderID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.CarrierID)
                .Index(t => t.ConsigneeID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.DealID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.TransferValue",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        PlannedTransferValueKey = c.Int(nullable: false),
                        PlannedTransferKey = c.Int(nullable: false),
                        TransferID = c.Guid(),
                        ValueStatus = c.String(),
                        ValueType = c.String(),
                        TransactionType = c.String(),
                        Provision = c.String(),
                        PerUnitValue = c.Double(),
                        PricedPerUnitValue = c.Double(),
                        FloatingPerUnitValue = c.Double(),
                        TotalValue = c.Double(),
                        PricedPercent = c.Double(),
                        SettlementCurrency = c.String(),
                        ValueCreatedDate = c.DateTime(),
                        ValueChangedDate = c.DateTime(),
                        LastValueDate = c.DateTime(),
                        ReferenceDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Transfer", t => t.TransferID)
                .Index(t => t.TransferID);
            
            CreateTable(
                "dbo.Movement",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        MovementDocumentKey = c.Int(nullable: false),
                        MovementHeaderKey = c.Int(nullable: false),
                        DocumentBAID = c.Guid(),
                        ReceiptCompanyID = c.Guid(),
                        DeliveryCompanyID = c.Guid(),
                        CarrierID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        VehicleID = c.Guid(),
                        ReceiptDealID = c.Guid(),
                        DeliveryDealID = c.Guid(),
                        OriginContainerID = c.Guid(),
                        DestinationContainerID = c.Guid(),
                        TransportID = c.Guid(),
                        MovementNumber = c.String(),
                        LineNumber = c.Int(),
                        ActivityType = c.String(),
                        DocumentStatus = c.String(),
                        MovementStatus = c.String(),
                        DocumentDate = c.DateTime(),
                        DocumentChangedDate = c.DateTime(),
                        MovementDate = c.DateTime(),
                        MovementChangedDate = c.DateTime(),
                        MovementTemplate = c.String(),
                        UserTemplate = c.String(),
                        Actualizer = c.String(),
                        MovementType = c.String(),
                        MovementExpenses = c.Int(),
                        NetQuantity = c.Double(),
                        GrossQuantity = c.Double(),
                        QuantityUnit = c.String(),
                        NetWeight = c.Double(),
                        GrossWeight = c.Double(),
                        WeightUnit = c.String(),
                        SpecificGravity = c.Double(),
                        APIGravity = c.Double(),
                        Description = c.String(),
                        ExternalBatch = c.String(),
                        TransportNumber = c.String(),
                        MeterNumber = c.String(),
                        TicketNumber = c.String(),
                        TankNumber = c.String(),
                        CountryOfOrigin = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CarrierID)
                .ForeignKey("dbo.BusinessAssociate", t => t.DeliveryCompanyID)
                .ForeignKey("dbo.Deal", t => t.DeliveryDealID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Container", t => t.DestinationContainerID)
                .ForeignKey("dbo.BusinessAssociate", t => t.DocumentBAID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.Container", t => t.OriginContainerID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ReceiptCompanyID)
                .ForeignKey("dbo.Deal", t => t.ReceiptDealID)
                .ForeignKey("dbo.Transport", t => t.TransportID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => t.DocumentBAID)
                .Index(t => t.ReceiptCompanyID)
                .Index(t => t.DeliveryCompanyID)
                .Index(t => t.CarrierID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.VehicleID)
                .Index(t => t.ReceiptDealID)
                .Index(t => t.DeliveryDealID)
                .Index(t => t.OriginContainerID)
                .Index(t => t.DestinationContainerID)
                .Index(t => t.TransportID);
            
            CreateTable(
                "dbo.MovementTransaction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        TransactionHeaderKey = c.Int(nullable: false),
                        PlannedTransferKey = c.Int(),
                        MovementHeaderKey = c.Int(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        DestinationID = c.Guid(),
                        PlannedOriginID = c.Guid(),
                        PlannedDestinationID = c.Guid(),
                        TransferID = c.Guid(),
                        MovementID = c.Guid(),
                        Status = c.String(),
                        SupplyDemand = c.String(),
                        MovementDate = c.DateTime(),
                        TransactionDate = c.DateTime(),
                        NetQuantity = c.Double(),
                        GrossQuantity = c.Double(),
                        QuantityUnit = c.String(),
                        NetWeight = c.Double(),
                        WeightUnit = c.String(),
                        SpecificGravity = c.Double(),
                        APIGravity = c.Double(),
                        MovementType = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Movement", t => t.MovementID)
                .ForeignKey("dbo.Location", t => t.PlannedDestinationID)
                .ForeignKey("dbo.Location", t => t.PlannedOriginID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Transfer", t => t.TransferID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.DestinationID)
                .Index(t => t.PlannedOriginID)
                .Index(t => t.PlannedDestinationID)
                .Index(t => t.TransferID)
                .Index(t => t.MovementID);
            
            CreateTable(
                "dbo.MovementTransactionValue",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        TransactionDetailKey = c.Int(nullable: false),
                        TransactionHeaderKey = c.Int(nullable: false),
                        MovementTransactionID = c.Guid(),
                        DealID = c.Guid(),
                        ValueStatus = c.String(),
                        ValueType = c.String(),
                        Actual = c.String(),
                        TransactionType = c.String(),
                        Provision = c.String(),
                        Strategy = c.String(),
                        DetailQuantity = c.Double(),
                        PerUnitValue = c.Double(),
                        PricedInValue = c.Double(),
                        FloatingValue = c.Double(),
                        TotalValue = c.Double(),
                        Currency = c.String(),
                        PricedPercent = c.Double(),
                        ValueCreatedDate = c.DateTime(),
                        ValuationDate = c.DateTime(),
                        RevisionDate = c.DateTime(),
                        ReferenceDate = c.DateTime(),
                        RevisionLevel = c.Int(),
                        QuantityBasis = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.MovementTransaction", t => t.MovementTransactionID)
                .Index(t => t.MovementTransactionID)
                .Index(t => t.DealID);
            
            CreateTable(
                "dbo.MovementExpense",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        MovementExpenseKey = c.Int(nullable: false),
                        MovementExpenseLogKey = c.Int(nullable: false),
                        PlannedTransferKey = c.Int(),
                        MovementHeaderKey = c.Int(),
                        InternalBAID = c.Guid(),
                        ExternalBAID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        TransferID = c.Guid(),
                        MovementID = c.Guid(),
                        TransactionType = c.String(),
                        PaymentType = c.String(),
                        Status = c.String(),
                        Reversal = c.String(),
                        CreatedDate = c.DateTime(),
                        ExpenseDate = c.DateTime(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        PerUnitValue = c.Double(),
                        TotalValue = c.Double(),
                        Currency = c.String(),
                        Strategy = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.ExternalBAID)
                .ForeignKey("dbo.BusinessAssociate", t => t.InternalBAID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Movement", t => t.MovementID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Transfer", t => t.TransferID)
                .Index(t => t.InternalBAID)
                .Index(t => t.ExternalBAID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.TransferID)
                .Index(t => t.MovementID);
            
            CreateTable(
                "dbo.TimeTransaction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        TimeTransactionKey = c.Int(nullable: false),
                        TimeTransactionLogKey = c.Int(),
                        DealID = c.Guid(),
                        Date = c.DateTime(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        ValueStatus = c.String(),
                        ValueType = c.String(),
                        TransactionType = c.String(),
                        Provision = c.String(),
                        Strategy = c.String(),
                        PerUnitValue = c.Double(),
                        PricedValue = c.Double(),
                        FloatingValue = c.Double(),
                        TotalValue = c.Double(),
                        Currency = c.String(),
                        PricedPercent = c.Double(),
                        ValuationDate = c.DateTime(),
                        RevisionDate = c.DateTime(),
                        ApplicationDate = c.DateTime(),
                        RevisionLevel = c.Int(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .Index(t => t.DealID);
            
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        InvoiceHeaderKey = c.Int(nullable: false),
                        InvoiceDetailKey = c.Int(),
                        OurCompanyID = c.Guid(),
                        TheirCompanyID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        InvoiceNumber = c.String(),
                        LineNumber = c.Int(),
                        InvoiceType = c.String(),
                        Status = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        InvoiceDate = c.DateTime(),
                        DueDate = c.DateTime(),
                        PaymentDate = c.DateTime(),
                        PostedDate = c.DateTime(),
                        AttachedDate = c.DateTime(),
                        AccountingPeriod = c.String(),
                        TotalValue = c.Double(),
                        PaidAmount = c.Double(),
                        LineAmount = c.Double(),
                        Currency = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        TransactionType = c.String(),
                        PaymentType = c.String(),
                        Approved = c.String(),
                        BOL = c.String(),
                        OriginalInvoice = c.String(),
                        OriginalSource = c.String(),
                        OriginalAmount = c.Double(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.BusinessAssociate", t => t.OurCompanyID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.TheirCompanyID)
                .Index(t => t.OurCompanyID)
                .Index(t => t.TheirCompanyID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID);
            
            CreateTable(
                "dbo.AccountingTransaction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        AccountDetailKey = c.Int(nullable: false),
                        AccountCodeKey = c.Int(),
                        AccountCodeLogKey = c.Int(),
                        PlannedTransferKey = c.Int(),
                        MovementHeaderKey = c.Int(),
                        TransactionHeaderKey = c.Int(),
                        InvoiceHeaderKey = c.Int(),
                        InvoiceDetailKey = c.Int(),
                        InvoiceType = c.String(),
                        OurCompanyID = c.Guid(),
                        TheirCompanyID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        OriginID = c.Guid(),
                        DestinationID = c.Guid(),
                        DealID = c.Guid(),
                        TransferID = c.Guid(),
                        MovementID = c.Guid(),
                        MovementTransactionID = c.Guid(),
                        MovementExpenseID = c.Guid(),
                        TimeTransactionID = c.Guid(),
                        InvoiceID = c.Guid(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        TransactionDate = c.DateTime(),
                        LogDate = c.DateTime(),
                        AccountingPeriod = c.String(),
                        AccountNumber = c.String(),
                        AccountDescription = c.String(),
                        AccountType = c.String(),
                        DebitCredit = c.String(),
                        Value = c.Double(),
                        Currency = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        TransactionType = c.String(),
                        Reversed = c.String(),
                        SourceTable = c.String(),
                        SourceID = c.Int(),
                        SupplyDemand = c.String(),
                        WePayTheyPay = c.String(),
                        AccountCodeStatus = c.String(),
                        TaxStatus = c.String(),
                        Intradivisional = c.String(),
                        IsNetOut = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.Location", t => t.DestinationID)
                .ForeignKey("dbo.Invoice", t => t.InvoiceID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Movement", t => t.MovementID)
                .ForeignKey("dbo.MovementExpense", t => t.MovementExpenseID)
                .ForeignKey("dbo.MovementTransaction", t => t.MovementTransactionID)
                .ForeignKey("dbo.Location", t => t.OriginID)
                .ForeignKey("dbo.BusinessAssociate", t => t.OurCompanyID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.BusinessAssociate", t => t.TheirCompanyID)
                .ForeignKey("dbo.TimeTransaction", t => t.TimeTransactionID)
                .ForeignKey("dbo.Transfer", t => t.TransferID)
                .Index(t => t.OurCompanyID)
                .Index(t => t.TheirCompanyID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.OriginID)
                .Index(t => t.DestinationID)
                .Index(t => t.DealID)
                .Index(t => t.TransferID)
                .Index(t => t.MovementID)
                .Index(t => t.MovementTransactionID)
                .Index(t => t.MovementExpenseID)
                .Index(t => t.TimeTransactionID)
                .Index(t => t.InvoiceID);
            
            CreateTable(
                "dbo.MonthEndInventory",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        EndingInventoryKey = c.Int(nullable: false),
                        CompanyID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        DealID = c.Guid(),
                        InventoryDate = c.DateTime(),
                        AccountingPeriod = c.String(),
                        RawQuantity = c.Double(),
                        RefinedQuantity = c.Double(),
                        TransferQuantity = c.Double(),
                        TotalQuantity = c.Double(),
                        UnitOfMeasure = c.String(),
                        ReconcileGroup = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CompanyID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.CompanyID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.DealID);
            
            CreateTable(
                "dbo.InventoryReconcile",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        InventoryReconcileKey = c.Int(nullable: false),
                        PlannedTransferKey = c.Int(),
                        TransactionHeaderKey = c.Int(),
                        CompanyID = c.Guid(),
                        ProductID = c.Guid(),
                        LocationID = c.Guid(),
                        DealID = c.Guid(),
                        TransferID = c.Guid(),
                        MovementTransactionID = c.Guid(),
                        ReconcileDate = c.DateTime(),
                        MovementDate = c.DateTime(),
                        AccountingPeriod = c.String(),
                        Status = c.String(),
                        SupplyDemand = c.String(),
                        Reversed = c.String(),
                        Pool = c.String(),
                        ReasonCode = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        ReconcileGroup = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusinessAssociate", t => t.CompanyID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.Location", t => t.LocationID)
                .ForeignKey("dbo.MovementTransaction", t => t.MovementTransactionID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Transfer", t => t.TransferID)
                .Index(t => t.CompanyID)
                .Index(t => t.ProductID)
                .Index(t => t.LocationID)
                .Index(t => t.DealID)
                .Index(t => t.TransferID)
                .Index(t => t.MovementTransactionID);
            
            CreateTable(
                "dbo.InventorySubledger",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        InventorySubledgerKey = c.Int(nullable: false),
                        ProductID = c.Guid(),
                        DealID = c.Guid(),
                        UpdateDate = c.DateTime(),
                        AccountingPeriod = c.String(),
                        Strategy = c.String(),
                        PerUnitLocked = c.String(),
                        Quantity = c.Double(),
                        QuantityUnit = c.String(),
                        Weight = c.Double(),
                        WeightUnit = c.String(),
                        Value = c.Double(),
                        PerUnitValue = c.Double(),
                        Currency = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deal", t => t.DealID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.DealID);
            
            CreateTable(
                "dbo.MessageQueue",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        ProcessIdentifier = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Data = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InventorySubledger", "ProductID", "dbo.Product");
            DropForeignKey("dbo.InventorySubledger", "DealID", "dbo.Deal");
            DropForeignKey("dbo.InventoryReconcile", "TransferID", "dbo.Transfer");
            DropForeignKey("dbo.InventoryReconcile", "ProductID", "dbo.Product");
            DropForeignKey("dbo.InventoryReconcile", "MovementTransactionID", "dbo.MovementTransaction");
            DropForeignKey("dbo.InventoryReconcile", "LocationID", "dbo.Location");
            DropForeignKey("dbo.InventoryReconcile", "DealID", "dbo.Deal");
            DropForeignKey("dbo.InventoryReconcile", "CompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MonthEndInventory", "ProductID", "dbo.Product");
            DropForeignKey("dbo.MonthEndInventory", "LocationID", "dbo.Location");
            DropForeignKey("dbo.MonthEndInventory", "DealID", "dbo.Deal");
            DropForeignKey("dbo.MonthEndInventory", "CompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.AccountingTransaction", "TransferID", "dbo.Transfer");
            DropForeignKey("dbo.AccountingTransaction", "TimeTransactionID", "dbo.TimeTransaction");
            DropForeignKey("dbo.AccountingTransaction", "TheirCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.AccountingTransaction", "ProductID", "dbo.Product");
            DropForeignKey("dbo.AccountingTransaction", "OurCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.AccountingTransaction", "OriginID", "dbo.Location");
            DropForeignKey("dbo.AccountingTransaction", "MovementTransactionID", "dbo.MovementTransaction");
            DropForeignKey("dbo.AccountingTransaction", "MovementExpenseID", "dbo.MovementExpense");
            DropForeignKey("dbo.AccountingTransaction", "MovementID", "dbo.Movement");
            DropForeignKey("dbo.AccountingTransaction", "LocationID", "dbo.Location");
            DropForeignKey("dbo.AccountingTransaction", "InvoiceID", "dbo.Invoice");
            DropForeignKey("dbo.AccountingTransaction", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.AccountingTransaction", "DealID", "dbo.Deal");
            DropForeignKey("dbo.Invoice", "TheirCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Invoice", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Invoice", "OurCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Invoice", "OriginID", "dbo.Location");
            DropForeignKey("dbo.Invoice", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Invoice", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.TimeTransaction", "DealID", "dbo.Deal");
            DropForeignKey("dbo.MovementExpense", "TransferID", "dbo.Transfer");
            DropForeignKey("dbo.MovementExpense", "ProductID", "dbo.Product");
            DropForeignKey("dbo.MovementExpense", "MovementID", "dbo.Movement");
            DropForeignKey("dbo.MovementExpense", "LocationID", "dbo.Location");
            DropForeignKey("dbo.MovementExpense", "InternalBAID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementExpense", "ExternalBAID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementTransactionValue", "MovementTransactionID", "dbo.MovementTransaction");
            DropForeignKey("dbo.MovementTransactionValue", "DealID", "dbo.Deal");
            DropForeignKey("dbo.MovementTransaction", "TransferID", "dbo.Transfer");
            DropForeignKey("dbo.MovementTransaction", "ProductID", "dbo.Product");
            DropForeignKey("dbo.MovementTransaction", "PlannedOriginID", "dbo.Location");
            DropForeignKey("dbo.MovementTransaction", "PlannedDestinationID", "dbo.Location");
            DropForeignKey("dbo.MovementTransaction", "MovementID", "dbo.Movement");
            DropForeignKey("dbo.MovementTransaction", "LocationID", "dbo.Location");
            DropForeignKey("dbo.MovementTransaction", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.Movement", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.Movement", "TransportID", "dbo.Transport");
            DropForeignKey("dbo.Movement", "ReceiptDealID", "dbo.Deal");
            DropForeignKey("dbo.Movement", "ReceiptCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Movement", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Movement", "OriginContainerID", "dbo.Container");
            DropForeignKey("dbo.Movement", "OriginID", "dbo.Location");
            DropForeignKey("dbo.Movement", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Movement", "DocumentBAID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Movement", "DestinationContainerID", "dbo.Container");
            DropForeignKey("dbo.Movement", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.Movement", "DeliveryDealID", "dbo.Deal");
            DropForeignKey("dbo.Movement", "DeliveryCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Movement", "CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.TransferValue", "TransferID", "dbo.Transfer");
            DropForeignKey("dbo.Transfer", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Transfer", "OriginID", "dbo.Location");
            DropForeignKey("dbo.Transfer", "OrderID", "dbo.Order");
            DropForeignKey("dbo.Transfer", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Transfer", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.Transfer", "DealID", "dbo.Deal");
            DropForeignKey("dbo.Transfer", "ConsigneeID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Transfer", "CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Order", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.Order", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Order", "OriginID", "dbo.Location");
            DropForeignKey("dbo.Order", "MovementPlanID", "dbo.MovementPlan");
            DropForeignKey("dbo.Order", "FinalDestinationID", "dbo.Location");
            DropForeignKey("dbo.Order", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.MovementPlan", "OriginProductID", "dbo.Product");
            DropForeignKey("dbo.MovementPlan", "OriginLocationID", "dbo.Location");
            DropForeignKey("dbo.MovementPlan", "Leg5OriginDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg5DestinationDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg5CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementPlan", "Leg4OriginDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg4DestinationDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg4CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementPlan", "Leg3OriginDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg3DestinationDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg3CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementPlan", "Leg2OriginDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg2DestinationDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg2CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementPlan", "Leg1OriginDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg1DestinationDealID", "dbo.Deal");
            DropForeignKey("dbo.MovementPlan", "Leg1CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.MovementPlan", "DestinationProductID", "dbo.Product");
            DropForeignKey("dbo.MovementPlan", "DestinationLocationID", "dbo.Location");
            DropForeignKey("dbo.Deal", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.Deal", "TheirCompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Deal", "ShipperID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Deal", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Deal", "OriginID", "dbo.Location");
            DropForeignKey("dbo.Deal", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Deal", "DivisionID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Deal", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.Deal", "CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.PositionGroup", "ProductID", "dbo.Product");
            DropForeignKey("dbo.PositionGroup", "LocationID", "dbo.Location");
            DropForeignKey("dbo.InventoryTagGroup", "DataSourceID", "dbo.DataSource");
            DropForeignKey("dbo.Inventory", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Inventory", "FacilityID", "dbo.Location");
            DropForeignKey("dbo.Inventory", "DataSourceID", "dbo.DataSource");
            DropForeignKey("dbo.Inventory", "ContainerID", "dbo.Container");
            DropForeignKey("dbo.Inventory", "CompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.InventoryHistory", "ProductID", "dbo.Product");
            DropForeignKey("dbo.InventoryHistory", "FacilityID", "dbo.Location");
            DropForeignKey("dbo.InventoryHistory", "DataSourceID", "dbo.DataSource");
            DropForeignKey("dbo.InventoryHistory", "ContainerID", "dbo.Container");
            DropForeignKey("dbo.InventoryHistory", "CompanyID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransfer", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.BulkTransfer", "TransportID", "dbo.Transport");
            DropForeignKey("dbo.BulkTransfer", "SupplierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransfer", "ShipperID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransfer", "ProductID", "dbo.Product");
            DropForeignKey("dbo.BulkTransfer", "OriginID", "dbo.Location");
            DropForeignKey("dbo.BulkTransfer", "FacilityID", "dbo.Location");
            DropForeignKey("dbo.BulkTransfer", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.BulkTransfer", "DataSourceID", "dbo.DataSource");
            DropForeignKey("dbo.BulkTransfer", "CustomerID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransfer", "ContainerID", "dbo.Container");
            DropForeignKey("dbo.BulkTransfer", "CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransferHistory", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.BulkTransferHistory", "TransportID", "dbo.Transport");
            DropForeignKey("dbo.BulkTransferHistory", "SupplierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransferHistory", "ShipperID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransferHistory", "ProductID", "dbo.Product");
            DropForeignKey("dbo.BulkTransferHistory", "OriginID", "dbo.Location");
            DropForeignKey("dbo.BulkTransferHistory", "FacilityID", "dbo.Location");
            DropForeignKey("dbo.BulkTransferHistory", "DestinationID", "dbo.Location");
            DropForeignKey("dbo.BulkTransferHistory", "DataSourceID", "dbo.DataSource");
            DropForeignKey("dbo.BulkTransferHistory", "CustomerID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.BulkTransferHistory", "ContainerID", "dbo.Container");
            DropForeignKey("dbo.Container", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Container", "FacilityID", "dbo.Location");
            DropForeignKey("dbo.BulkTransferHistory", "CarrierID", "dbo.BusinessAssociate");
            DropForeignKey("dbo.Activity", "DataSourceID", "dbo.DataSource");
            DropIndex("dbo.InventorySubledger", new[] { "DealID" });
            DropIndex("dbo.InventorySubledger", new[] { "ProductID" });
            DropIndex("dbo.InventoryReconcile", new[] { "MovementTransactionID" });
            DropIndex("dbo.InventoryReconcile", new[] { "TransferID" });
            DropIndex("dbo.InventoryReconcile", new[] { "DealID" });
            DropIndex("dbo.InventoryReconcile", new[] { "LocationID" });
            DropIndex("dbo.InventoryReconcile", new[] { "ProductID" });
            DropIndex("dbo.InventoryReconcile", new[] { "CompanyID" });
            DropIndex("dbo.MonthEndInventory", new[] { "DealID" });
            DropIndex("dbo.MonthEndInventory", new[] { "LocationID" });
            DropIndex("dbo.MonthEndInventory", new[] { "ProductID" });
            DropIndex("dbo.MonthEndInventory", new[] { "CompanyID" });
            DropIndex("dbo.AccountingTransaction", new[] { "InvoiceID" });
            DropIndex("dbo.AccountingTransaction", new[] { "TimeTransactionID" });
            DropIndex("dbo.AccountingTransaction", new[] { "MovementExpenseID" });
            DropIndex("dbo.AccountingTransaction", new[] { "MovementTransactionID" });
            DropIndex("dbo.AccountingTransaction", new[] { "MovementID" });
            DropIndex("dbo.AccountingTransaction", new[] { "TransferID" });
            DropIndex("dbo.AccountingTransaction", new[] { "DealID" });
            DropIndex("dbo.AccountingTransaction", new[] { "DestinationID" });
            DropIndex("dbo.AccountingTransaction", new[] { "OriginID" });
            DropIndex("dbo.AccountingTransaction", new[] { "LocationID" });
            DropIndex("dbo.AccountingTransaction", new[] { "ProductID" });
            DropIndex("dbo.AccountingTransaction", new[] { "TheirCompanyID" });
            DropIndex("dbo.AccountingTransaction", new[] { "OurCompanyID" });
            DropIndex("dbo.Invoice", new[] { "DestinationID" });
            DropIndex("dbo.Invoice", new[] { "OriginID" });
            DropIndex("dbo.Invoice", new[] { "LocationID" });
            DropIndex("dbo.Invoice", new[] { "ProductID" });
            DropIndex("dbo.Invoice", new[] { "TheirCompanyID" });
            DropIndex("dbo.Invoice", new[] { "OurCompanyID" });
            DropIndex("dbo.TimeTransaction", new[] { "DealID" });
            DropIndex("dbo.MovementExpense", new[] { "MovementID" });
            DropIndex("dbo.MovementExpense", new[] { "TransferID" });
            DropIndex("dbo.MovementExpense", new[] { "LocationID" });
            DropIndex("dbo.MovementExpense", new[] { "ProductID" });
            DropIndex("dbo.MovementExpense", new[] { "ExternalBAID" });
            DropIndex("dbo.MovementExpense", new[] { "InternalBAID" });
            DropIndex("dbo.MovementTransactionValue", new[] { "DealID" });
            DropIndex("dbo.MovementTransactionValue", new[] { "MovementTransactionID" });
            DropIndex("dbo.MovementTransaction", new[] { "MovementID" });
            DropIndex("dbo.MovementTransaction", new[] { "TransferID" });
            DropIndex("dbo.MovementTransaction", new[] { "PlannedDestinationID" });
            DropIndex("dbo.MovementTransaction", new[] { "PlannedOriginID" });
            DropIndex("dbo.MovementTransaction", new[] { "DestinationID" });
            DropIndex("dbo.MovementTransaction", new[] { "LocationID" });
            DropIndex("dbo.MovementTransaction", new[] { "ProductID" });
            DropIndex("dbo.Movement", new[] { "TransportID" });
            DropIndex("dbo.Movement", new[] { "DestinationContainerID" });
            DropIndex("dbo.Movement", new[] { "OriginContainerID" });
            DropIndex("dbo.Movement", new[] { "DeliveryDealID" });
            DropIndex("dbo.Movement", new[] { "ReceiptDealID" });
            DropIndex("dbo.Movement", new[] { "VehicleID" });
            DropIndex("dbo.Movement", new[] { "DestinationID" });
            DropIndex("dbo.Movement", new[] { "OriginID" });
            DropIndex("dbo.Movement", new[] { "LocationID" });
            DropIndex("dbo.Movement", new[] { "ProductID" });
            DropIndex("dbo.Movement", new[] { "CarrierID" });
            DropIndex("dbo.Movement", new[] { "DeliveryCompanyID" });
            DropIndex("dbo.Movement", new[] { "ReceiptCompanyID" });
            DropIndex("dbo.Movement", new[] { "DocumentBAID" });
            DropIndex("dbo.TransferValue", new[] { "TransferID" });
            DropIndex("dbo.Transfer", new[] { "OrderID" });
            DropIndex("dbo.Transfer", new[] { "DealID" });
            DropIndex("dbo.Transfer", new[] { "DestinationID" });
            DropIndex("dbo.Transfer", new[] { "OriginID" });
            DropIndex("dbo.Transfer", new[] { "LocationID" });
            DropIndex("dbo.Transfer", new[] { "ProductID" });
            DropIndex("dbo.Transfer", new[] { "ConsigneeID" });
            DropIndex("dbo.Transfer", new[] { "CarrierID" });
            DropIndex("dbo.Order", new[] { "MovementPlanID" });
            DropIndex("dbo.Order", new[] { "VehicleID" });
            DropIndex("dbo.Order", new[] { "FinalDestinationID" });
            DropIndex("dbo.Order", new[] { "DestinationID" });
            DropIndex("dbo.Order", new[] { "OriginID" });
            DropIndex("dbo.Order", new[] { "ProductID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg5DestinationDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg5OriginDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg4DestinationDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg4OriginDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg3DestinationDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg3OriginDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg2DestinationDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg2OriginDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg1DestinationDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg1OriginDealID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg5CarrierID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg4CarrierID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg3CarrierID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg2CarrierID" });
            DropIndex("dbo.MovementPlan", new[] { "Leg1CarrierID" });
            DropIndex("dbo.MovementPlan", new[] { "DestinationLocationID" });
            DropIndex("dbo.MovementPlan", new[] { "OriginLocationID" });
            DropIndex("dbo.MovementPlan", new[] { "DestinationProductID" });
            DropIndex("dbo.MovementPlan", new[] { "OriginProductID" });
            DropIndex("dbo.Deal", new[] { "VehicleID" });
            DropIndex("dbo.Deal", new[] { "DestinationID" });
            DropIndex("dbo.Deal", new[] { "OriginID" });
            DropIndex("dbo.Deal", new[] { "LocationID" });
            DropIndex("dbo.Deal", new[] { "ProductID" });
            DropIndex("dbo.Deal", new[] { "ShipperID" });
            DropIndex("dbo.Deal", new[] { "CarrierID" });
            DropIndex("dbo.Deal", new[] { "DivisionID" });
            DropIndex("dbo.Deal", new[] { "TheirCompanyID" });
            DropIndex("dbo.PositionGroup", new[] { "LocationID" });
            DropIndex("dbo.PositionGroup", new[] { "ProductID" });
            DropIndex("dbo.InventoryTagGroup", new[] { "DataSourceID" });
            DropIndex("dbo.Inventory", new[] { "CompanyID" });
            DropIndex("dbo.Inventory", new[] { "ProductID" });
            DropIndex("dbo.Inventory", new[] { "ContainerID" });
            DropIndex("dbo.Inventory", new[] { "FacilityID" });
            DropIndex("dbo.Inventory", new[] { "DataSourceID" });
            DropIndex("dbo.InventoryHistory", new[] { "CompanyID" });
            DropIndex("dbo.InventoryHistory", new[] { "ProductID" });
            DropIndex("dbo.InventoryHistory", new[] { "ContainerID" });
            DropIndex("dbo.InventoryHistory", new[] { "FacilityID" });
            DropIndex("dbo.InventoryHistory", new[] { "DataSourceID" });
            DropIndex("dbo.BulkTransfer", new[] { "VehicleID" });
            DropIndex("dbo.BulkTransfer", new[] { "TransportID" });
            DropIndex("dbo.BulkTransfer", new[] { "CarrierID" });
            DropIndex("dbo.BulkTransfer", new[] { "ShipperID" });
            DropIndex("dbo.BulkTransfer", new[] { "SupplierID" });
            DropIndex("dbo.BulkTransfer", new[] { "CustomerID" });
            DropIndex("dbo.BulkTransfer", new[] { "ProductID" });
            DropIndex("dbo.BulkTransfer", new[] { "ContainerID" });
            DropIndex("dbo.BulkTransfer", new[] { "DestinationID" });
            DropIndex("dbo.BulkTransfer", new[] { "OriginID" });
            DropIndex("dbo.BulkTransfer", new[] { "FacilityID" });
            DropIndex("dbo.BulkTransfer", new[] { "DataSourceID" });
            DropIndex("dbo.Container", new[] { "ProductID" });
            DropIndex("dbo.Container", new[] { "FacilityID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "VehicleID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "TransportID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "CarrierID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "ShipperID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "SupplierID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "CustomerID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "ProductID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "ContainerID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "DestinationID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "OriginID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "FacilityID" });
            DropIndex("dbo.BulkTransferHistory", new[] { "DataSourceID" });
            DropIndex("dbo.Activity", new[] { "DataSourceID" });
            DropTable("dbo.MessageQueue");
            DropTable("dbo.InventorySubledger");
            DropTable("dbo.InventoryReconcile");
            DropTable("dbo.MonthEndInventory");
            DropTable("dbo.AccountingTransaction");
            DropTable("dbo.Invoice");
            DropTable("dbo.TimeTransaction");
            DropTable("dbo.MovementExpense");
            DropTable("dbo.MovementTransactionValue");
            DropTable("dbo.MovementTransaction");
            DropTable("dbo.Movement");
            DropTable("dbo.TransferValue");
            DropTable("dbo.Transfer");
            DropTable("dbo.Order");
            DropTable("dbo.MovementPlan");
            DropTable("dbo.Deal");
            DropTable("dbo.PositionGroup");
            DropTable("dbo.User");
            DropTable("dbo.RefineryInventoryError");
            DropTable("dbo.Log");
            DropTable("dbo.InventoryTagGroup");
            DropTable("dbo.Inventory");
            DropTable("dbo.InventoryHistory");
            DropTable("dbo.IBEXTransaction");
            DropTable("dbo.IBEXTransactionHistory");
            DropTable("dbo.Error");
            DropTable("dbo.BulkTransfer");
            DropTable("dbo.Vehicle");
            DropTable("dbo.Transport");
            DropTable("dbo.Product");
            DropTable("dbo.Location");
            DropTable("dbo.Container");
            DropTable("dbo.BusinessAssociate");
            DropTable("dbo.BulkTransferHistory");
            DropTable("dbo.DataSource");
            DropTable("dbo.Activity");
        }
    }
}
