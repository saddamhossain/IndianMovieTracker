using IndianMovieTracker.Interface;
using IndianMovieTracker.Model;
using IndianMovieTracker.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovieTracker.Service
{
    public class MovieService : IMovie
    {
        public IList<Industry> GetIndustries()
        {
            Seed obj = new Seed();
            var result = obj.industries.ToList();
            return result;
        }

        public IList<Actor> GetActors()
        {
            Seed obj = new Seed();
            var result = obj.actors.ToList();
            return result;
        }

        public IList<Actor> GetActorsByIndustry(string industry)
        {
            Seed obj = new Seed();
            var result = obj.actors.Where(s=>s.Industry == industry).ToList();
            return result;
        }

        public IList<Movie> GetAllMovies()
        {
            Seed obj = new Seed();
            var result = obj.mohanlal.Concat(obj.mammootty).Concat(obj.rajini).Concat(obj.kamal).Concat(obj.aamir).Concat(obj.amitabh).Concat(obj.shahrukh).ToList();
            return result;
        }

        public IList<Movie> GetMoviesByAamir(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.aamir.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByAmitabh(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.amitabh.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByKamal(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.kamal.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByMammootty(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.mammootty.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByMohanlal(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.mohanlal.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByRajini(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.rajini.ToList();
            return result;
        }

        public IList<Movie> GetMoviesByShahrukh(string actorName)
        {
            Seed obj = new Seed();
            var result = obj.shahrukh.ToList();
            return result;
        }


        #region IDisposable Support
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
