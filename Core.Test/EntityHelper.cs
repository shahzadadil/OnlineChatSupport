using Domain.Entities;
using Domain.Entities.Core;

namespace Core.Test
{
    public class EntityHelper
    {
        private readonly EntitiesContext _context;

        public EntityHelper(EntitiesContext context)
        {
            _context = context;
        }

        public void Agent(string name, string extension, string status)
        {
            var agent = new Agent
            {
                Name = name,
                Extension = extension,
                Status = status
            };

            _context.Agents.Add(agent);
        }
    }
}
