using Domain.Entities.Core;
using NUnit.Framework;

namespace Core.Test
{
    [TestFixture]
    public class TestBase
    {
        protected EntitiesContext Context;
        protected EntityHelper Entity { get; set; }

        [SetUp]
        protected void SetUp()
        {
            Context = new EntitiesContext();

            if (Context.Database.Exists())
            {
                Context.Database.Delete();
            }

            Context.Database.Create();

            Entity = new EntityHelper(Context);
        }

        [TearDown]
        protected void TearDown()
        {
            Context.Database.Delete();
            Entity = null;
            Context.Dispose();
        }

        protected void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected void RefreshContext()
        {
            Context.Dispose();
            Context = new EntitiesContext();
        }
    }
}
