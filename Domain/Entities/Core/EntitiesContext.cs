using System.Data.Entity;

namespace Domain.Entities.Core
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("ChatSupport")
        {
            
        }

        public DbSet<Agent> Agents { get; set; }
    }
}
