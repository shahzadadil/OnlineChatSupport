using System.ComponentModel.DataAnnotations;
using Domain.Entities.Core;

namespace Domain.Entities
{
    public class Agent : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(6)]
        public string Extension { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
