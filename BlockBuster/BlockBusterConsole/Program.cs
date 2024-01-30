using BlockBuster;
using BlockBusterConsole;

var _args = Environment.GetCommandLineArgs();

var movies = BlockBusterBasicFunctions.GetAllMovies();

var oh = new OutputHelper();

var choice = _args[1].ToString();

if (choice == "true")
{
    oh.WriteToConsole(movies);
}
else
{
    oh.WriteToCSV(movies);
}
