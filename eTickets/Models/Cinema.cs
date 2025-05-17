using System.ComponentModel.DataAnnotations;
using eTickets.Data.enums;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public required string Logo { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; } = [];
    }
}
