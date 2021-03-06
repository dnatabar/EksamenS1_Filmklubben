﻿using System;
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

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An Entry object to compare this object with</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.
        /// </returns>
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        /// <param name="movieId">Movie_Id of the Movie Object</param>
        /// <param name="memberId">Member_Id of the Member Object</param>
        /// <param name="rating">Rating from 1 - 5</param>
        /// <param name="priority">Priority from 1 - 5</param>
        public Entry(int movieId, int memberId, int rating, int priority)
        {
            this.MovieId = movieId;
            this.MemberId = memberId;
            this.Rating = rating;
            this.Priority = priority;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        /// <param name="movie">Movie Object reference.</param>
        /// <param name="member">Member Object reference.</param>
        /// <param name="rating">Rating from 1 - 5</param>
        /// <param name="priority">Priority from 1 - 5</param>
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
