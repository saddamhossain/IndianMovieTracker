using IndianMovieTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovieTracker.Interface
{
    public interface IMovie : IDisposable
    {
        IList<Industry> GetIndustries();
        IList<Actor> GetActors();
        IList<Actor> GetActorsByIndustry(string industry);
        IList<Movie> GetAllMovies();
        IList<Movie> GetMoviesByAamir(string actorName);
        IList<Movie> GetMoviesByAmitabh(string actorName);
        IList<Movie> GetMoviesByKamal(string actorName);
        IList<Movie> GetMoviesByMammootty(string actorName);
        IList<Movie> GetMoviesByMohanlal(string actorName);
        IList<Movie> GetMoviesByRajini(string actorName);
        IList<Movie> GetMoviesByShahrukh(string actorName);
    }
}
