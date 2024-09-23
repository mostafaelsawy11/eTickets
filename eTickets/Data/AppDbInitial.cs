using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitial
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicesScopes = applicationBuilder.ApplicationServices.CreateScope())
            {
                using (var context = servicesScopes.ServiceProvider.GetService < AppDbContext >())
                {
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Logo="1.jpg",
                            Name="Cinema 1",
                            Description="This is Description of the first Cinema"
                        },
                        new Cinema()
                        {
                            Logo="2.jpg",
                            Name="Cinema 2",
                            Description="This is Description of the second Cinema"
                        },
                        new Cinema()
                        {
                            Logo="3.jpg",
                            Name="Cinema 3",
                            Description="This is Description of the third Cinema"
                        },
                        new Cinema()
                        {
                            Logo="4.jpg",
                            Name="Cinema 4",
                            Description="This is Description of the fourth Cinema"
                        },
                        new Cinema()
                        {
                            Logo="5.jpg",
                            Name="Cinema 5",
                            Description="This is Description of the fifth Cinema"
                        }
                    }
                        );
                        context.SaveChanges();
                    }
                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureUrl="1.jpg",
                            fullName="John cina",
                            Bio="This is Description of John cina"
                        },
                        new Actor()
                        {
                            ProfilePictureUrl="2.jpg",
                            fullName="the rock",
                            Bio="This is Description of the rock"
                        },
                        new Actor()
                        {
                            ProfilePictureUrl="3.jpg",
                            fullName="Ahmed helmey",
                            Bio="This is Description of Ahmed helmey"
                        },
                        new Actor()
                        {
                            ProfilePictureUrl="4.jpg",
                            fullName="Abu terika",
                            Bio="This is Description of Abu terika"
                        },
                        new Actor()
                        {
                            ProfilePictureUrl="5.jpg",
                            fullName="Mohamed salah",
                            Bio="This is Description of Mohamed salah"
                        }
                    }
                        );
                        context.SaveChanges();
                    }
                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                         new Producer()
                        {
                            ProfilePictureUrl="1.jpg",
                            fullName="John cina",
                            Bio="This is Description of John cina"
                        },
                        new Producer()
                        {
                            ProfilePictureUrl="2.jpg",
                            fullName="the rock",
                            Bio="This is Description of the rock"
                        },
                        new Producer()
                        {
                            ProfilePictureUrl="3.jpg",
                            fullName="Ahmed helmey",
                            Bio="This is Description of Ahmed helmey"
                        },
                        new Producer()
                        {
                            ProfilePictureUrl="4.jpg",
                            fullName="Abu terika",
                            Bio="This is Description of Abu terika"
                        },
                        new Producer()
                        {
                            ProfilePictureUrl="5.jpg",
                            fullName="Mohamed salah",
                            Bio="This is Description of Mohamed salah"
                        }
                    }


                        );
                        context.SaveChanges();
                    }
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name= "Movie 1",
                            Description="this is Movie One Action",
                            startDate=DateTime.Now.AddDays(-10),
                            endDate=DateTime.Now.AddDays(-3),
                            Price = 39.5,
                            ImageUrl = "1.jpg",
                            movieCategory = MovieCategory.Action ,
                            CinemaId = 1 ,
                            ProducerId=6

                        },
                        new Movie()
                        {
                            Name= "Movie 2",
                            Description="this is Movie two Comedy",
                            startDate=DateTime.Now.AddDays(-10),
                            endDate=DateTime.Now.AddDays(-1),
                            Price = 39.5,
                            ImageUrl = "2.jpg",
                            movieCategory = MovieCategory.Comedy,
                            CinemaId = 3 ,
                            ProducerId=7

                        },
                        new Movie()
                        {
                            Name= "Movie 3",
                            Description="this is Movie three Action",
                            startDate=DateTime.Now.AddDays(-8),
                            endDate=DateTime.Now.AddDays(-3),
                            Price = 39.5,
                            ImageUrl = "3.jpg",
                            movieCategory = MovieCategory.Action ,
                            CinemaId = 4 ,
                            ProducerId=9

                        },
                        new Movie()
                        {
                            Name= "Movie 4",
                            Description="this is Movie four documentry",
                            startDate=DateTime.Now.AddDays(-7),
                            endDate=DateTime.Now.AddDays(-3),
                            Price = 39.5,
                            ImageUrl = "4.jpg",
                            movieCategory = MovieCategory.Documentry ,
                            CinemaId = 3 ,
                            ProducerId=8

                        },
                        new Movie()
                        {
                            Name= "Movie 5",
                            Description="this is Movie five Drama",
                            startDate=DateTime.Now.AddDays(-6),
                            endDate=DateTime.Now.AddDays(1),
                            Price = 39.5,
                            ImageUrl = "5.jpg",
                            movieCategory = MovieCategory.Drama ,
                            CinemaId = 2,
                            ProducerId=10

                        },

                    }
                        );
                        context.SaveChanges();
                    }




                }
            }
        }
    }
}
