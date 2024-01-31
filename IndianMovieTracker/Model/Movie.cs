using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovieTracker.Model
{
    public class Movie
    {
        public string Industry { set; get; }
        public string Actor { set; get; }
        public int Year { set; get; }
        public string Title { set; get; }
        public string Role { set; get; }
        public string Director { set; get; }
        public string Language { set; get; }
    }
}
