using System.Collections.Generic;
using System.Web.Http;
using Core.Repositories;
using Domain.ViewModels.Agent;

namespace Web.Controllers
{
    public class AgentController : ApiController
    {
        public IAgentRepository AgentRepository { get; set; }

        public IEnumerable<AgentModel> Get()
        {
            var agents = AgentRepository.Get();

            return agents;
        }
    }
}
