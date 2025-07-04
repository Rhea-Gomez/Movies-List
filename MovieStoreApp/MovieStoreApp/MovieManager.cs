using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MovieStoreApp
{
    public class MovieManager
    {

        List<Movies> movieList = new List<Movies>();

        public void AddMovies()
        {
            Random random = new Random();
            int id = random.Next(100, 999);

            Console.Write("Enter Movie Title : ");
            string name = Console.ReadLine();

            Console.Write("Enter Year Of Release : ");
            string year = Console.ReadLine();

            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Movies movie = new Movies(id, name, year, genre);

            try
            {
                if (movieList.Count > 5)
                {
                    throw new MaximumMoviesException("Cannot add more than 5 movies");
                }
                else
                {
                    movieList.Add(movie);
                    Console.WriteLine("Movie added successfully");
                }
                    
            }
            catch (MaximumMoviesException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }

        }

        public void DisplayAllMovies()
        {
            if(movieList.Count == 0)
            {
                Console.WriteLine("No movies in the list. List is empty");
            } else
            {
                foreach (object movie in movieList)
                {
                    Console.WriteLine(movie.ToString());
                }
            }
                
        }

        public void FindMovieByID()
        {
            Console.Write("Enter Movie ID: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (Movies movie in movieList)
            {
                if (movie is Movies m && m.Id == id)
                {

                    found = true;
                    Console.WriteLine(movie.ToString());
                    break;
                }
                
            }
            try
            {
                if (!found)
                {
                    throw new InvalidIDException("ID is invalid. Cannot fetch movie details");
                }


            }
            catch (InvalidIDException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveMovieByID()
        {
            Console.Write("Enter Movie ID: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < movieList.Count; i++)
            {
                if (movieList[i] is Movies m && m.Id == id)
                {
                    found = true;
                    movieList.RemoveAt(i);
                    Console.WriteLine($"Movie with Id: {id} has been removed successfully");
                    break;
                }
                
            }
            try
            {
                if (!found)
                {
                    throw new InvalidIDException("ID is invalid. Cannot fetch movie details");
                }


            }
            catch (InvalidIDException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ClearAllMovies()
        {
            movieList.Clear();
            Console.WriteLine("All movies in the list has been cleared successfully");
        }
    }
}

