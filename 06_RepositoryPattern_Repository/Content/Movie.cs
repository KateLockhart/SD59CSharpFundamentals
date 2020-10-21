using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository.Content
{
    public class Movie : StreamingContent
    {
        //can call the base constructor before the {}
        //directly passes overloaded constuctors from the parent one
        public Movie() : base() { }
        public Movie(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre, double runTime)
            : base(title, description, maturityRating, starRating, releaseYear, genre)
        {
            //runTime is a local one so needs to be here, parent will not recieve it
            RunTime = runTime;
        }

        // Minutes
        public double RunTime { get; set; }
    }
}
