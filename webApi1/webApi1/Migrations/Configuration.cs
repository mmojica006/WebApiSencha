namespace webApi1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using webApi1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<webApi1.Models.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Contactoes.AddOrUpdate(
                new Contacto { Nombre="moises Mojica"},
                new Contacto { Nombre = "Aida Marbely" },
                new Contacto { Nombre="Marcelo Andress"}
                );
        }
    }
}
