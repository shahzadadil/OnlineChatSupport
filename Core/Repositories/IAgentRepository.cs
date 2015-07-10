using Domain.ViewModels.Agent;

namespace Core.Repositories
{
    public interface IAgentRepository
    {
        AgentModel[] Get();
    }
}
