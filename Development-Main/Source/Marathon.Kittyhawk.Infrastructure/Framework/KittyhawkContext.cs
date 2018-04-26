using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Marathon.Kittyhawk.Infrastructure.Mapping;

namespace Marathon.Kittyhawk.Infrastructure.Framework
{
	/// <summary>
	/// Defines the context class used as the bridge between Entity Framework and the
	/// application's entity repository implementations.
	/// </summary>
	public class KittyhawkContext : DbContext
    {
        /// <summary>
        /// Returns the connection string based on the current environment as specified
        /// in the application's configuration settings.
        /// </summary>
        private static string Connection
        {
            get
            {
				string connection = KittyhawkConnection.ConnectionString;
				return connection;
            }
        }

        /// <summary>
        /// Default constructor.  Injects the connection string before calling the base constructor.
        /// </summary>
        public KittyhawkContext() : base(Connection)
		{
			this.Database.CommandTimeout = 300;
		}

        /// <summary>
        /// Defines the mapping between the application's entities and the database.
        /// </summary>
        /// <param name="modelBuilder">Model builder definition</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties<Guid>().Where(x => x.Name == "ID").Configure(x => 
                x.IsKey()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("ID")
                .HasColumnOrder(0));
            modelBuilder.Properties<DateTime>().Where(x => x.Name == "Timestamp").Configure(x =>
                x.HasColumnName("Timestamp")
                .HasColumnOrder(1)
                .IsRequired());

            modelBuilder.Configurations.Add(new ActivityMap());
            modelBuilder.Configurations.Add(new BulkTransferHistoryMap());
            modelBuilder.Configurations.Add(new BulkTransferMap());
            modelBuilder.Configurations.Add(new BusinessAssociateMap());
            modelBuilder.Configurations.Add(new ContainerMap());
            modelBuilder.Configurations.Add(new ChemicalMap());
            modelBuilder.Configurations.Add(new DataSourceMap());
            modelBuilder.Configurations.Add(new ErrorMap());
            modelBuilder.Configurations.Add(new IBEXTransactionHistoryMap());
            modelBuilder.Configurations.Add(new IBEXTransactionMap());
            modelBuilder.Configurations.Add(new InventoryHistoryMap());
            modelBuilder.Configurations.Add(new InventoryMap());
            modelBuilder.Configurations.Add(new InventoryTagGroupMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RefineryInventoryErrorMap());
            modelBuilder.Configurations.Add(new TransportMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new VehicleMap());
            modelBuilder.Configurations.Add(new PositionGroupMap());
            modelBuilder.Configurations.Add(new DealMap());
            modelBuilder.Configurations.Add(new DealObligationMap());
            modelBuilder.Configurations.Add(new MovementPlanMap());
            modelBuilder.Configurations.Add(new OfficeAddressMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new TerritoryManagerMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new TransferMap());
            modelBuilder.Configurations.Add(new TransferValueMap());
            modelBuilder.Configurations.Add(new MovementMap());
            modelBuilder.Configurations.Add(new MovementTransactionMap());
            modelBuilder.Configurations.Add(new MovementTransactionValueMap());
            modelBuilder.Configurations.Add(new MovementExpenseMap());
            modelBuilder.Configurations.Add(new TimeTransactionMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new AccountingTransactionMap());
            modelBuilder.Configurations.Add(new MonthEndInventoryMap());
            modelBuilder.Configurations.Add(new InventoryReconcileMap());
            modelBuilder.Configurations.Add(new InventorySubledgerMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new TransactionUploadHistoryMap());
            modelBuilder.Configurations.Add(new TransactionUploadMap());
            modelBuilder.Configurations.Add(new SalesForecastMap());
            modelBuilder.Configurations.Add(new SalesForecastHistoryMap());
            modelBuilder.Configurations.Add(new UnitofMeasureMap());
            modelBuilder.Configurations.Add(new MatchStatusMap());
            modelBuilder.Configurations.Add(new HolidayCalendarMap());
            modelBuilder.Configurations.Add(new HolidayCalendarDetailMap());
            modelBuilder.Configurations.Add(new CommodityMap());
            modelBuilder.Configurations.Add(new AllocationManagerFilterMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new PriceServiceMap());
            modelBuilder.Configurations.Add(new DeliveryPeriodCategoryMap());
            modelBuilder.Configurations.Add(new DeliveryPeriodCategoryDetailMap());
            modelBuilder.Configurations.Add(new TransactionTypeMap());
            modelBuilder.Configurations.Add(new DynamicListBoxMap());
        }
    }
}
