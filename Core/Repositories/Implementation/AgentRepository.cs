using System.Linq;
using Domain.Entities.Core;
using Domain.ViewModels.Agent;

namespace Core.Repositories.Implementation
{
    public class AgentRepository : IAgentRepository
    {
        public AgentModel[] Get()
        {
            using (var context = new EntitiesContext())
            {
                return context.Agents.Select(a => new AgentModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Extension = a.Extension,
                    Status = a.Status
                })
                .OrderBy(a => a.Name)
                .ToArray();
            }
        }
    }
}
