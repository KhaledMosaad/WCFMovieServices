using System.Collections.Generic;
using System.Linq;

namespace ITI.Movie.Services
{
    public class MovieService: IMovieService
    {
        private static List<Movie> movies = new List<Movie> { 
            new Movie{Id =1,Name="Toy Store"},
            new Movie{Id=2,Name="Lion King"}
        };
        public Movie Add(Movie movie)
        {
            movies.Add(movie);
            return movie;
        }
        public List<Movie> GetAll()
        {
            return movies;
        }
        public Movie Modify(Movie movie)
        {
            movies.RemoveAll(m => m.Id == movie.Id);
            movies.Add(movie);
            return movie;
        }
        public void Remove(int id)
        {
            movies.RemoveAll(m=>m.Id==id);
        }
    }
}