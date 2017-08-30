namespace Login.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Login.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Login.Models.LoginContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Login.Models.LoginContext context)
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

            context.Users.AddOrUpdate(
                u => u.Name,
                new User { Name = "Dev" },
                new User { Name = "Guest" }
                );

            context.Records.AddOrUpdate(
                r => new { r.UserName, r.StageNum },
                new Record { UserName = "Dev", StageNum = 1, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 2, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 3, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 4, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 5, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 6, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 7, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 8, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 9, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 10, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 11, Stars = 3 },
                new Record { UserName = "Dev", StageNum = 12, Stars = 3 },
                new Record { UserName = "Guest", StageNum = 1, Stars = 1 }
                );
        }
    }
}
