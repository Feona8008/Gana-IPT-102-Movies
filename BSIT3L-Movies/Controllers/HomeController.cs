using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Image = "~/images/titanic.jpg" }, 
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Image = "~/images/inception.jpg"  },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Image = "~/images/TheShawshankRedemption.jpg"  },
            new MovieViewModel { Id = 4, Name = "Guardians of the Galaxy", Rating = "8", ReleaseYear = 2014, Genre = "Science Fiction/Action",Image = "~/images/GuardiansOfTheGalaxy.jpg" },
            new MovieViewModel { Id = 5, Name = "The Nun", Rating = "5", ReleaseYear = 2018, Genre = "Horror", Image = "~/images/TheNun.jpg" },
            new MovieViewModel { Id = 6, Name = "A Quiet Place", Rating = "7", ReleaseYear = 2018, Genre = "Horror", Image = "~/images/AQuietPlace.jpg" },
            new MovieViewModel { Id = 7, Name = "John Wick", Rating = "8", ReleaseYear = 2023, Genre = "Action", Image = "~/images/JohnWick.jpg" },
            new MovieViewModel { Id = 8, Name = "Kill Boksoon", Rating = "5", ReleaseYear = 2023, Genre = "Action", Image = "~/images/KillBoksoon.jpg" },
            new MovieViewModel { Id = 9, Name = "Polite Society", Rating = "7", ReleaseYear = 2023, Genre = "Action", Image = "~/images/PoliteSociety.jpg" },
            new MovieViewModel { Id = 10, Name = "The Mother", Rating = "8", ReleaseYear = 2023, Genre = "Action", Image = "~/images/TheMother.jpg" },
            new MovieViewModel { Id = 11, Name = "Barcelona", Rating = "5", ReleaseYear = 2016, Genre = "Romance", Image = "~/images/Barcelona.jpg" },
            new MovieViewModel { Id = 12, Name = "Haunted Mansion", Rating = "7", ReleaseYear = 2023, Genre = "Fantasy", Image = "~/images/HauntedMansion.jpg" },
            new MovieViewModel { Id = 13, Name = "Spy", Rating = "8", ReleaseYear = 2023, Genre = "Fantasy", Image = "~/images/Spy.jpg" },
            new MovieViewModel { Id = 14, Name = "Barbie", Rating = "5", ReleaseYear = 2023, Genre = "Comedy", Image = "~/images/Barbie.jpg" },
            new MovieViewModel { Id = 15, Name = "Dream", Rating = "7", ReleaseYear = 2023, Genre = "Comedy", Image = "~/images/Dream.jpg" },
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

