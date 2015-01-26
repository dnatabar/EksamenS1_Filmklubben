using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmklubben
{
    public class Movie : IComparable<Movie>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string CoverURL { get; set; }

        
        public int CompareTo(Movie other)
        {
            return this.ReleaseDate.CompareTo(other.ReleaseDate);
            
        }

        public Movie()
        {

        }

        public Movie(int id, string title, DateTime releaseDate, string description) : this(id, title, releaseDate, description, "")
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="id">Movie_Id of object, -1 or lower for movies without a row in the Database.</param>
        /// <param name="title">Movie title</param>
        /// <param name="releaseDate">Release date</param>
        /// <param name="description">Description of the Movie</param>
        /// <param name="coverURL">Direct URL to a Cover, JPG,PNG,GIF,BMP supported</param>
        public Movie(int id, string title, DateTime releaseDate, string description, string coverURL)
        {

            this.Id = id;
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Description = description;
            this.CoverURL = coverURL;
        }

        public Movie(string title, DateTime releaseDate, string description)
            : this(-1, title, releaseDate, description)
        {

        }

        public Movie(string title, DateTime releasedate, string description, string coverURL) : this(-1, title, releasedate, description, coverURL)
        {

        }

        public override string ToString()
        {
            return this.Id + ": " + this.Title + " (" + this.ReleaseDate.Month + "/" + this.ReleaseDate.Year + ")";
        }
    }
}
