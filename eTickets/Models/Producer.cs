using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public required string ProfilePictureURL { get; set; }
        public required string FullName { get; set; }
        public required string Bio { get; set; }

        // Relationships
        public List<Movie>? Movies { get; set; }
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
