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
                        Console.WriteLine();
                        break;
                    case 2:
                        manager.DisplayAllMovies();
                        Console.WriteLine();
                        break;
                    case 3:
                        manager.FindMovieByID();
                        Console.WriteLine();
                        break;
                    case 4:
                        manager.RemoveMovieByID();
                        Console.WriteLine();
                        break;
                    case 5:
                        manager.ClearAllMovies();
                        Console.WriteLine();
                        break;
                    case 6: //to do exit
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        Console.WriteLine();
                        break;
                }
            } while (choice != 6);
            
            

        }
    }
}
