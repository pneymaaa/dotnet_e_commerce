using System.ComponentModel.DataAnnotations;

namespace dotnet_e_commerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        public List<Movie>? Movies { get; set; }

    }
}