using Core.Repositories;
using Domain.ViewModels.Agent;
using Microsoft.AspNet.SignalR;

namespace Web.Communication
{
    public class AgentHub : Hub
    {
        public IAgentRepository AgentRepository { get; set; }

        public void UpdateStatus(AgentStatusModel status)
        {
            var agentStatus = new AgentStatusModel
            {
                AgentId = status.AgentId,
                Status = status.Status
            };

            var success = AgentRepository.UpdateStatus(agentStatus);

            if (!success) return;

            var hub = GlobalHost.ConnectionManager.GetHubContext<CustomerHub>();
            hub.Clients.All.updateAgentStatus(status);
        }
    }
}