using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   
    class Cinema : IEnumerable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private Movie[] movies;


        public Cinema(string name,string address, Movie[] movies)
        {
            Name = name;
            Address = address;
            this.movies = movies;
        }


        public IEnumerator<Movie> GetEnumerator()
        {
            return ((IEnumerable<Movie>)movies).GetEnumerator();
        }


        public void Sort()
        {
            Array.Sort(movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\nAddress: {Address}\n");
            
            for(int i = 0; i < movies.Length; i++)
            {
                sb.Append(i+1+"."+movies[i]+"\n");
            }
            return sb.ToString();
        }
    }

    class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
  
    
}