using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnet_e_commerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Profile Picture URL")]
        public string? ImageUrl { get; set; }
        [DisplayName("Full Name")]
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}