using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "Guardians of the Galaxy", Rating = "8", ReleaseYear = 2014, Genre = "Science Fiction/Action" },
            new MovieViewModel { Id = 5, Name = "The Nun", Rating = "5", ReleaseYear = 2018, Genre = "Horror" },
            new MovieViewModel { Id = 6, Name = "A Quiet Place", Rating = "7", ReleaseYear = 2018, Genre = "Horror" },
            new MovieViewModel { Id = 7, Name = "John Wick", Rating = "8", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 8, Name = "Kill Boksoon", Rating = "5", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 9, Name = "Polite Society", Rating = "7", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 10, Name = "The Mother", Rating = "8", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 11, Name = "Barcelona", Rating = "5", ReleaseYear = 2016, Genre = "Romance" },
            new MovieViewModel { Id = 12, Name = "Haunted Mansion", Rating = "7", ReleaseYear = 2023, Genre = "Fantasy" },
            new MovieViewModel { Id = 13, Name = "Spy", Rating = "8", ReleaseYear = 2023, Genre = "Fantasy" },
            new MovieViewModel { Id = 14, Name = "Barbie", Rating = "5", ReleaseYear = 2023, Genre = "Comedy" },
            new MovieViewModel { Id = 15, Name = "Dream", Rating = "7", ReleaseYear = 2023, Genre = "Comedy" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

