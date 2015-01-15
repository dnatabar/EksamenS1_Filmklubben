using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmklubben
{
    public class Entry : IComparable<Entry>
    {
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public int Rating { get; set; }
        public int Priority { get; set; }

        private Movie MovieRef { get; set; }

        private Member MemberRef { get; set; }


        public int CompareTo(Entry other)
        {
            if (this.Priority == other.Priority)
            {
                if (this.Rating == other.Rating)
                {
                    if (this.MovieRef != null && other.MovieRef != null)
                    {
                        return this.MovieRef.Title.CompareTo(other.MovieRef.Title);
                    }
                    else
                    {
                        return 0;
                    }
                }
                return other.Rating.CompareTo(this.Rating);
            }
            else
            {
                return other.Priority.CompareTo(this.Priority);
            }
        }


        public Entry()
        {

        }

        public Entry(int movieId, int memberId, int rating, int priority)
        {
            this.MovieId = movieId;
            this.MemberId = memberId;
            this.Rating = rating;
            this.Priority = priority;
        }

        public Entry(Movie movie, Member member, int rating, int priority) : this(movie.Id, member.Id, rating, priority)
        {
            this.MovieRef = movie;
            this.MemberRef = member;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (MovieRef == null)
                sb.Append("ID: " + this.MovieId);
            else
                sb.Append(this.MovieRef.Title);

            sb.Append(" | R: " + this.Rating + " | P: " + this.Priority);

            return sb.ToString();
        }

        public void SetMovieRef(Movie movieRef)
        {
            if (movieRef != null)
            {
                this.MovieRef = movieRef;
            }
        }

        public void SetMemberRef(Member memberRef)
        {
            if (memberRef != null)
            {
                this.MemberRef = memberRef;
            }
        }




    }
}
