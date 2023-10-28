using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnet_e_commerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string? ImageUrl { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        public string? Bio { get; set; }

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}