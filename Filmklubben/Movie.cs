using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmklubben
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }


        public Movie()
        {

        }

        public Movie(int id, string title, DateTime releaseDate, string description)
        {
            this.Id = id;
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Description = description;
        }

        public Movie(string title, DateTime releaseDate, string description) : this(-1, title, releaseDate, description)
        {

        }

        public override string ToString()
        {
            return this.Id + ": " + this.Title + " (" + this.ReleaseDate.Month + "/" + this.ReleaseDate.Year + ")";
        }
    }
}
