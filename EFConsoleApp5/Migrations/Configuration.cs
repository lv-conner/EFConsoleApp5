namespace EFConsoleApp5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MyContextConfiguration : DbMigrationsConfiguration<Context>
    {
        public MyContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFConsoleApp5.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
