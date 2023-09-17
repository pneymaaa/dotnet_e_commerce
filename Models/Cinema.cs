using System.ComponentModel.DataAnnotations;

namespace dotnet_e_commerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<Movie>? Movies { get; set; }

    }
}