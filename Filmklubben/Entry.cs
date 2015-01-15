using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmklubben
{
    public class Entry
    {
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public int Rating { get; set; }
        public int Priority { get; set; }

        private Movie MovieRef { get; set; }

        private Member MemberRef { get; set; }

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
