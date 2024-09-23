using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public string Logo { get; set; }
        [Required(ErrorMessage = "This value is Required")]
        [MaxLength(100, ErrorMessage = "The max Length is 100")]
        [MinLength(3, ErrorMessage = "The min Length is 3")]

        public string Name { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public string Description { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
