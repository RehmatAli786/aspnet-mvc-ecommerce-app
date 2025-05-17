using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public required string ActorProfileURL { get; set; }
        public required string FullName { get; set; }
        public required string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
