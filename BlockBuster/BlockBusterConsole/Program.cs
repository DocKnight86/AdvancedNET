using BlockBuster;
using BlockBuster.Models;
using BlockBusterConsole;

string[] _args = Environment.GetCommandLineArgs();
OutputHelper oh = new OutputHelper();

string outputFormat = _args[1].ToUpper();
string methodName = _args[2];

switch (methodName)
{
    case "GetMovieById":
    {
        if (_args.Length > 3)
        {
            int id = int.Parse(_args[3]);
            Movie movie = BlockBusterBasicFunctions.GetMovieById(id);

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(new List<Movie> { movie });
            }
            else
            {
                oh.WriteToConsole(new List<Movie> { movie });
            }
        }
        else
        {
            Console.WriteLine("Missing id parameter for GetMovieById.");
        }

        break;
    }
    case "GetAllMovies":
    {
        List<Movie> allMovies = BlockBusterBasicFunctions.GetAllMovies();

        if (outputFormat == "CSV")
        {
            oh.WriteToCSV(allMovies);
        }
        else
        {
            oh.WriteToConsole(allMovies);
        }

        break;
    }
    case "GetAllCheckedOutMovies":
    {
        List<Movie> checkedOutMovies = BlockBusterBasicFunctions.GetAllCheckedOutMovies();

        if (outputFormat == "CSV")
        {
            oh.WriteToCSV(checkedOutMovies);
        }
        else
        {
            oh.WriteToConsole(checkedOutMovies);
        }

        break;
    }
    case "GetMoviesByGenre":
    {
        if (_args.Length > 3)
        {
            string genreDescription = _args[3];
            List<Movie> moviesByGenre = BlockBusterBasicFunctions.GetMoviesByGenre(genreDescription);

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(moviesByGenre);
            }
            else
            {
                oh.WriteToConsole(moviesByGenre);
            }
        }
        else
        {
            Console.WriteLine("Missing genre description for GetMoviesByGenre.");
        }

        break;
    }
    case "GetMoviesByDirectorLastName":
    {
        if (_args.Length > 3)
        {
            string lastName = _args[3];
            List<Movie> moviesByDirector = BlockBusterBasicFunctions.GetMoviesByDirectorLastName(lastName);

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(moviesByDirector);
            }
            else
            {
                oh.WriteToConsole(moviesByDirector);
            }
        }
        else
        {
            Console.WriteLine("Missing director's last name for GetMoviesByDirectorLastName.");
        }

        break;
    }
    case "GetMovieByTitle":
    {
        if (_args.Length > 3)
        {
            string title = _args[3];
            Movie movieByTitle = BlockBusterBasicFunctions.GetMovieByTitle(title);

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(new List<Movie> { movieByTitle });
            }
            else
            {
                oh.WriteToConsole(new List<Movie> { movieByTitle });
            }
        }
        else
        {
            Console.WriteLine("Missing title for GetMovieByTitle.");
        }

        break;
    }
    default:
    {
        Console.WriteLine($"Unknown method name: {methodName}");

        break;
    }
}
