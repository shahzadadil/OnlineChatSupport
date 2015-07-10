using Domain.Entities;
using Domain.Entities.Core;

namespace Domain.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<EntitiesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntitiesContext context)
        {
            context.Agents.RemoveRange(context.Agents);

            context.Agents.AddOrUpdate(new[]
            {
                new Agent {Id=1, Name="Tom", Extension = "111", Status = "on call"},
                new Agent {Id=2, Name="Harry", Extension = "312", Status = "on call"},
                new Agent {Id=3, Name="Betty", Extension = "215", Status = "available"},
                new Agent {Id=4, Name="Robert", Extension = "761", Status = "offline"},
                new Agent {Id=5, Name="Frank", Extension = "123", Status = "inactive"},
                new Agent {Id=6, Name="Sam", Extension = "231", Status = "available"}
            });
        }
    }
}
