using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id {  get; set; }
        [Required(ErrorMessage ="This value is Required")]
        public string ProfilePictureUrl { get; set; }
        [Required(ErrorMessage = "This value is Required")]
        [MaxLength(100,ErrorMessage ="The max Length is 100")]
        [MinLength(3, ErrorMessage = "The min Length is 3")]

        public string fullName { get; set; }
        [Required(ErrorMessage = "This value is Required")]

        public string Bio { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
