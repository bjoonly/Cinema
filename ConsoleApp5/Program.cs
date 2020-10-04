using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Cinema
{

    class Program
    {


        static void Main(string[] args)
        {

            Movie[] movies = new Movie[] {
                new Movie("Parasite",
                "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan. ",
                2017,
                Genre.Drama,
                new Director("Bong", "Joon-ho","South Korea"),
                "Korean",
                7),

                new Movie("Avengers: Endgame",
                "Adrift in space with no food or water, Tony Stark sends a message to Pepper Potts as his oxygen supply starts to dwindle. Meanwhile, the remaining Avengers -- Thor, Black Widow, Captain America and Bruce Banner -- must figure out a way to bring back their vanquished allies for an epic showdown with Thanos -- the evil demigod who decimated the planet and the universe. ",
                2019,
                Genre.Fantasy,
                new Director("Anthony","Russo","USA"),
                "USA",
                8),

                new Movie("Knives Out",
                "The circumstances surrounding the death of crime novelist Harlan Thrombey are mysterious, but there's one thing that renowned Detective Benoit Blanc knows for sure -- everyone in the wildly dysfunctional Thrombey family is a suspect. Now, Blanc must sift through a web of lies and red herrings to uncover the truth. ",
                2016,
                Genre.Crime,
                new Director("Ruan","Johnson","USA"),
                "USA",
                9)
                };

            Console.WriteLine("Create and fill cinema:");
            Cinema cinema = new Cinema("Era", "dqdqd11", movies);
            Console.WriteLine(cinema + "\n");
            Console.WriteLine("\nSort movies:");
            cinema.Sort();
            Console.WriteLine(cinema + "\n");
            Console.WriteLine("\nSort by year: ");
            cinema.Sort(new CompareByYear());
            foreach (var movie in cinema)
                Console.WriteLine(movie + "\n");
            Console.WriteLine("\nSort by rating:");
            cinema.Sort(new CompareByRating());
            Console.WriteLine(cinema);

        }
    }
}
