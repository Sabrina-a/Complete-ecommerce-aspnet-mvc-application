using E_Tickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data
{
    public static class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                   {
                       new Cinema()
                       {
                           Name = "cinema 1",
                           Logo = "https://media-cdn.tripadvisor.com/media/photo-s/16/95/56/2f/reel-cinemas-logo.jpg",
                           Description = "This is the description of the first cinema"
                       },
                        new Cinema()
                       {
                           Name = "cinema 2",
                           Logo = "https://cdn3.vectorstock.com/i/1000x1000/11/72/cinema-logo-vector-36011172.jpg",
                           Description = "This is the description of the second cinema"
                       },
                         new Cinema()
                       {
                           Name = "cinema 3",
                           Logo = "https://cdn5.vectorstock.com/i/1000x1000/37/94/cinema-logo-vector-20903794.jpg",
                           Description = "This is the description of the third cinema"
                       },
                          new Cinema()
                       {
                           Name = "cinema 4",
                           Logo = "https://t4.ftcdn.net/jpg/01/25/57/91/360_F_125579108_cKIL8gnBgRKqcLeyG03llZNaeFOjoCLH.jpg",
                           Description = "This is the description of the fourth cinema"
                       },
                          new Cinema()
                       {
                           Name = "cinema 5",
                           Logo = "https://cdn3.vectorstock.com/i/1000x1000/11/72/cinema-logo-vector-36011172.jpg",
                           Description = "This is the description of the fifth cinema"
                       }
                   });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                         new Actor()
                         {
                            FullName="Jim Carrey",
                            Bio = "This is the Bio of The first actor",
                            ProfilePictureURL = "https://www.projectcasting.com/wp-content/uploads/2014/09/Jim-Carrey.jpg"
                         },
                         new Actor()
                         {
                            FullName="Morgan",
                            Bio = "This is the Bio of The second actor",
                            ProfilePictureURL = "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F180523162106-01-morgan-freeman-lead-image.jpg"
                         },
                         new Actor()
                         {
                            FullName="Al Pachino",
                            Bio = "This is the Bio of The third actor",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTkzNjA4OTQ5Nl5BMl5BanBnXkFtZTgwNzE4NjIwMjE@._V1_.jpg"
                         },
                         new Actor()
                         {
                            FullName="Anderow Garfield",
                            Bio = "This is the Bio of The fourth actor",
                            ProfilePictureURL = "https://www.showbizjunkies.com/wp-content/uploads/2021/06/Andrew-Garfield-under-banner-heaven.jpg"
                         },
                         new Actor()
                         {
                            FullName="Anne Hathaway",
                            Bio = "This is the Bio of The fifth actor",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/original/tLelKoPNiyJCSEtQTz1FGv4TLGc.jpg"
                         }

                    });
                    context.SaveChanges();
                }

                //Producers
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {

                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL="https://m.media-amazon.com/images/M/MV5BNDAyMzQ3MTYtMTQyYy00ZTUyLWI0M2QtODA4NjI3ZWIyZTRlXkEyXkFqcGdeQXVyNTI5NjIyMw@@._V1_UY1200_CR175,0,630,1200_AL_.jpg"
                        },
                         new Producer()
                        {
                            FullName="Producer 2",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL="https://m.media-amazon.com/images/M/MV5BOTRlN2UwNTEtNTI3OS00ZmYwLTk0NzktODViNjUxZjdjYTZlXkEyXkFqcGdeQXVyMjA0MTYzNzI@._V1_.jpg"
                        },
                          new Producer()
                        {
                            FullName="Producer 3",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL="https://assets.mycast.io/actor_images/actor-robert-engelman-40101_large.jpg?1581457626"
                        },
                           new Producer()
                        {
                            FullName="Producer 4",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL=""
                        },
                            new Producer()
                        {
                            FullName="Producer 5",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Alex_Kurtzman_San_Diego_Comic_Con_2019.jpg/1200px-Alex_Kurtzman_San_Diego_Comic_Con_2019.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {
                    new Movie()
                    {
                        Name = "The Mask",
                        Description = " desc for first film",
                        Price = 30,
                        ImagrURL="https://i5.walmartimages.com/asr/5f63ad84-f6a1-4d84-bcd9-efe4d3f8d717_1.8f67c8ba40db5206840a167e688d068b.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF",
                        StartDate=DateTime.Now.AddDays(-14),
                        EndDate=DateTime.Now.AddDays(-3),
                        CinemaId=5,
                        ProducerId=5,
                        MovieCategory=MovieCategory.Comedy,
                    },
                     new Movie()
                    {
                        Name = "Now You See Me",
                        Description = " desc for second film",
                        Price = 30,
                        ImagrURL="https://m.media-amazon.com/images/M/MV5BMTY0NDY3MDMxN15BMl5BanBnXkFtZTcwOTM5NzMzOQ@@._V1_.jpg",
                        StartDate=DateTime.Now.AddDays(-17),
                        EndDate=DateTime.Now.AddDays(-3),
                        CinemaId=4,
                        ProducerId=4,
                        MovieCategory=MovieCategory.Action,
                    },
                     new Movie()
                       {
                        Name = "One Day",
                        Description = " desc for third film",
                        Price = 20.5,
                        ImagrURL="https://media-cache.cinematerial.com/p/500x/lpgiy0ug/one-day-saudi-arabian-movie-poster.jpg?v=1456705795",
                        StartDate=DateTime.Now.AddDays(-27),
                        EndDate=DateTime.Now.AddDays(-3),
                        CinemaId=3,
                        ProducerId=3,
                        MovieCategory=MovieCategory.Romance,
                    },
                      new Movie()
                       {
                        Name = "Scent Of A Woman",
                        Description = " desc for fourth film",
                        Price = 40.5,
                        ImagrURL="https://media.elcinema.com/uploads/_315x420_2d73a6e84a3c38ddb41f39090e2ac5a385dce8f95006a571e0713b2cb8f09cbc.jpg",
                        StartDate=DateTime.Now.AddDays(-12),
                        EndDate=DateTime.Now.AddDays(-3),
                        CinemaId=2,
                        ProducerId=2,
                        MovieCategory=MovieCategory.Drama,
                    },
                       new Movie()
                       {
                        Name = "Hacksaw Ridge",
                        Description = " desc for fifth film",
                        Price = 50.5,
                        ImagrURL="https://m.media-amazon.com/images/I/91zzOGydODL._AC_SL1500_.jpg",
                        StartDate=DateTime.Now.AddDays(-10),
                        EndDate=DateTime.Now.AddDays(-3),
                        CinemaId=1,
                        ProducerId=1,
                        MovieCategory=MovieCategory.Documentry,
                    }


                    }) ;
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=3
                        },
                         new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        },
                          new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=2
                        },
                           new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=4
                        },
                            new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=5
                        },
                             new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=3
                        },
                              new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=2
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
