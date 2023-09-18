using System.Security.AccessControl;
using dotnet_e_commerce.Models;

namespace dotnet_e_commerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context?.Database.EnsureCreated();

                if(context != null && !context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() 
                    {
                        new Cinema() 
                        {
                            Name = "Cinema 1",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema() 
                        {
                            Name = "Cinema 2",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema() 
                        {
                            Name = "Cinema 3",
                            Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        }
                    });
                    context.SaveChanges();

                }
                if(context != null && !context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() 
                    {
                        new Actor() 
                        {
                            FullName = "Actor 1",
                            Bio = "This is bio of the first actor",
                            ImageUrl = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor() 
                        {
                            FullName = "Actor 2",
                            Bio = "This is bio of the second actor",
                            ImageUrl = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor() 
                        {
                            FullName = "Actor 3",
                            Bio = "This is bio of the third actor",
                            ImageUrl = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if(context != null && !context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() 
                        {
                            new Producer() 
                            {
                                FullName = "'Producer 1",
                                ImageUrl = "https://dotnethow.net/images/producer/producer-1",
                                Bio = "This is bio of the first producer"
                            },
                            new Producer() 
                            {
                                FullName = "'Producer 2",
                                ImageUrl = "https://dotnethow.net/images/producer/producer-2",
                                Bio = "This is bio of the second producer"
                            },
                            new Producer() 
                            {
                                FullName = "'Producer 3",
                                ImageUrl = "https://dotnethow.net/images/producer/producer-3",
                                Bio = "This is bio of the third producer"
                            }
                        });
                        context.SaveChanges();
                }
                if(context != null && !context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() 
                    {
                        new Movie() 
                        {
                            Name = "Movie 1",
                            Description = "This is description of first movie",
                            Price = 10,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enum.MovieCategory.Comedy
                        },
                        new Movie() 
                        {
                            Name = "Movie 2",
                            Description = "This is description of second movie",
                            Price = 20,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enum.MovieCategory.Action
                        },
                        new Movie() 
                        {
                            Name = "Movie 3",
                            Description = "This is description of third movie",
                            Price = 30,
                            ImageUrl = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enum.MovieCategory.Drama
                        },
                    });
                    context.SaveChanges();
                }
                if(context != null && !context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>() 
                    {
                        new Actor_Movie() 
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie() 
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie() 
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}