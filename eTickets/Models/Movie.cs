using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.enums;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public required string ImgURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public required Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public required Producer Producers { get; set; }
    }
}
