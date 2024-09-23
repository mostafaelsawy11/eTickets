using eTickets.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This value is Required")]
        [MaxLength(100, ErrorMessage = "The max Length is 100")]
        [MinLength(3, ErrorMessage = "The min Length is 3")]

        public string Name { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public string Description { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public DateTime startDate { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public DateTime endDate { get; set; }
        [Required(ErrorMessage = "This value is Required")]
        [Range(20,100)]

        public double Price { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public string ImageUrl { get; set; }
        public MovieCategory movieCategory { get; set; }
        [ForeignKey("Cinema")]
        [Required(ErrorMessage = "This value is Required")]

        public int CinemaId { get; set; }
        public virtual Cinema? Cinema { get; set; }
        [ForeignKey("Producer")]
        [Required(ErrorMessage = "This value is Required")]

        public int ProducerId { get; set; }
        public virtual Producer? Producer { get; set; }
        public virtual ICollection<Actor>? Actors { get; set; }
    }
}
