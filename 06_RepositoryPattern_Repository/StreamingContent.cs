using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    // CRUD Create, Read, Update, Delete

    // POCO
    // Plain old C# Object
    // is just used for storing values and information.
    
    public class StreamingContent
    {
        // Constructors - method that fires off to build the objects 
        // building two, where one overloads to fill in properties
        public StreamingContent() { }
        //after adding the IsFamilyFriendly bool change we can remove it from the constructor because that will generate from the property thus isn't required info to build the StreamingContent
        //it is no longer being assigned to because it goes off the MaturityRating info
        public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating, int releaseYear, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            ReleaseYear = releaseYear;
            Genre = genre;
        }


        // Property
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public double StarRating { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsFamilyFriendly 
        {
            get
            {
                // Figure out if it's Family Friendly and return true or false, switch case is better/more efficent 
                //if (MaturityRating == MaturityRating.G)
                //{
                //    return true;
                //}
                //else if (MaturityRating == MaturityRating.PG)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                // CAN ALSO WRITE AS A SWITCH CASE (return implies a break, it gets out of the accessor once it finds the t/f)
                switch(MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                        return true;
                    case MaturityRating.R:
                    default:
                        return false;
                }
            }
        }
        public GenreType Genre { get; set; }
    }

    /*
    Users have been complaining about their family friendly content. 
    Some users have been reporting that when filtering for family friendly, 
    they're getting some content with inappropriate maturity ratings. 
    We need to fix this. Currently the maturity rating and family friendly bool are independent, 
    we need to tie them together. 
    
    If something is rated R (or another similar rating), 
    it should never be able to have a IsFamilyFriendly of true. 
    We need you to refactor the code StreamingContent class. To help narrow down our problem, 
    we want to replace the MaturityRating with a default set of options. 
    Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
    */


    public enum GenreType
    {
        ActionAdventure, 
        Thriller, 
        Horror, 
        Comedy, 
        Bromance, 
        Mystery, 
        SciFi
    }

    //another way to do the challenge as an enum
     public enum MaturityRating
    {
        G, PG, PG13, R, NC17, TV_Y, TV_PG, TV_14, TV_MA
    }
     
}
