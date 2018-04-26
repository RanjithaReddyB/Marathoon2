namespace Marathon.Kittyhawk.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Marathon.Kittyhawk.Infrastructure.Framework.KittyhawkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Kittyhawk.Infrastructure.Framework.KittyhawkContext context)
        {

        }
    }
}
