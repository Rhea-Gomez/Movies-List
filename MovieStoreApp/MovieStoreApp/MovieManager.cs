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

        List<object> movieList = new List<object>();

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
                if (movieList.Count > 0)
                {
                    throw new Exception("Cannot add more than 5 movies");
                }
                movieList.Add(movie);
            }
            catch (MaximumMoviesException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Movie added successfully");
            }

        }

        public void DisplayAllMovies()
        {
            foreach(object movie in movieList)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        public void FindMovieByID()
        {
            Console.Write("Enter Movie ID: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                foreach (object movie in movieList)
                {
                    if (movie is Movies m)
                    {
                        if (m.Id == id)
                        {
                            Console.WriteLine(movie.ToString());
                            break;
                        }
                        else if (m.Id != id)
                        {
                            throw new InvalidIDException("ID is invalid. Cannot fetch movie details");
                        }
                    }
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

            try { 
            for(int i = 0; i < movieList.Count; i++)
            {
                if(movieList[i] is Movies m)
                {
                    if(m.Id == id)
                    {
                        movieList.RemoveAt(i);
                            break;
                    }
                    else
                    {
                        throw new InvalidIDException("ID is invalid. Cannot fetch movie details");
                    }
                }
            }
        } 
        catch (InvalidIDException ex)
        {
            Console.WriteLine(ex.Message);
        }
        }

        public void ClearAllMovies()
        {
            for(int i = 0; i < movieList.Count; i++)
            {
                movieList.RemoveAt(i);
            }
        }
    }
}

