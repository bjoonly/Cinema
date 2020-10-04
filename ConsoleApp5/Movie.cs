using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    enum Genre { Action, Adventure, Comedy, Crime, Drama, Fantasy, Historical, HistoricalFiction, Horror, Romance, ScienceFiction, Thriller, Western };
    class Movie : ICloneable, IComparable<Movie>
    {
        private int year;
        private short rating;
        public string Tittle { get; set; }
        public string Description { get; set; }
        public Director Director { get; set; }

        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1)
                    value = 1;
            
                    year = value;
            }
        }

        public short Rating
        {
            get { return rating; }
            set
            {
                if (value < 0)
                    value = 0;
                
                rating = value;
            }
        }
        public Movie(string tittle, string description, int year, Genre genre, Director direcror, string country, short rating)
        {
            Tittle = tittle;
            Description = description;
            Genre = genre;
            Year = year;
            Director = direcror;
            Country = country;
            Rating = rating;

        }
        public override string ToString()
        {
            return $"Tittle: {Tittle}\nGenre: {Genre}\nYear: {Year}\nCountry: {Country}\nRating: {Rating}\nDescription: {Description}";
        }

        public object Clone()
        {
            Movie copy = (Movie)this.MemberwiseClone();
            copy.Director = (Director)Director.Clone();
            return copy;
        }

        public int CompareTo(Movie other)
        {
            return Tittle.CompareTo(other.Tittle);
        }
    }
}
