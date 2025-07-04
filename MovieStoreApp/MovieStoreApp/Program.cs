using System.Collections;
namespace MovieStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            MovieManager manager = new MovieManager();
            do
            {
                Console.WriteLine("Welcome to Movie Store App!");
                Console.WriteLine("Select an option from the given menu: ");
                Console.WriteLine("1. Add new Movie \n2. Display All Movies \n3. Find Movie By ID \n4. Remove Movie by ID \n5. Clear All Movies \n6. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddMovies();
                        break;
                    case 2:
                        manager.DisplayAllMovies();
                        break;
                    case 3:
                        manager.FindMovieByID();
                        break;
                    case 4:
                        manager.RemoveMovieByID();
                        break;
                    case 5:
                        manager.ClearAllMovies();
                        break;
                    case 6: //to do exit
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            } while (choice != 6);
            
            

        }
    }
}
