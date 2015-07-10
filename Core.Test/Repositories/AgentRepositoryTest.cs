using Core.Repositories.Implementation;
using NUnit.Framework;

namespace Core.Test.Repositories
{
    [TestFixture]
    public class AgentRepositoryTest : TestBase
    {
        [Test]
        public void Get_ListAgents_ReturnsAgentList()
        {
            //ARRANGE
            Entity.Agent("Agent1", "111", "Status1");
            Entity.Agent("Agent2", "222", "Status2");
            Entity.Agent("Agent3", "333", "Status3");

            SaveChanges();

            var repository = new AgentRepository();

            //ACT
            var agents = repository.Get();

            //ASSERT
            Assert.That(agents, Has.Length.EqualTo(3));

            Assert.That(agents[0].Name, Is.EqualTo("Agent1"));
            Assert.That(agents[0].Extension, Is.EqualTo("111"));
            Assert.That(agents[0].Status, Is.EqualTo("Status1"));

            Assert.That(agents[1].Name, Is.EqualTo("Agent2"));
            Assert.That(agents[1].Extension, Is.EqualTo("222"));
            Assert.That(agents[1].Status, Is.EqualTo("Status2"));

            Assert.That(agents[2].Name, Is.EqualTo("Agent3"));
            Assert.That(agents[2].Extension, Is.EqualTo("333"));
            Assert.That(agents[2].Status, Is.EqualTo("Status3"));
        }

        [Test]
        public void Get_ListAgentsSortedOnName_ReturnsSortedAgents()
        {
            //ARRANGE
            Entity.Agent("Abgent1", "111", "Status1");
            Entity.Agent("XAgent2", "222", "Status2");
            Entity.Agent("Agent3", "333", "Status3");

            SaveChanges();

            var repository = new AgentRepository();

            //ACT
            var agents = repository.Get();

            //ASSERT
            Assert.That(agents, Has.Length.EqualTo(3));

            Assert.That(agents[0].Name, Is.EqualTo("Abgent1"));
            Assert.That(agents[1].Name, Is.EqualTo("Agent3"));
            Assert.That(agents[2].Name, Is.EqualTo("XAgent2"));
        }
    }
}
