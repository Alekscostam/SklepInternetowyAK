namespace SklepInternetowyAK.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SklepInternetowyAK.DAL.FilmsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SklepInternetowyAK.DAL.FilmsContext";
        }

        protected override void Seed(SklepInternetowyAK.DAL.FilmsContext context)
        {
            DAL.FilmsInitializer.SeedFilmy(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
