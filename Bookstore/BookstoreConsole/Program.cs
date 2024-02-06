using Bookstore;
using Bookstore.Models;
using BookstoreConsole;

string[] _args = Environment.GetCommandLineArgs();
OutputHelper oh = new OutputHelper();

string outputFormat = _args[1].ToUpper();
string methodName = _args[2];

switch (methodName)
{
    case "GetBookByTitle":
    {
        if (_args.Length > 3)
        {
            string title = _args[3];
            Book bookByTitle = BookStoreBasicFunctions.GetBookByTitle(title);

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(new List<Book> { bookByTitle });
            }
            else
            {
                oh.WriteToConsole(new List<Book> { bookByTitle });
            }
        }
        else
        {
            Console.WriteLine("Missing title for GetBookByTitle.");
        }

        break;
    }
    case "GetAllBooks":
        {
            List<Book> allBooks = BookStoreBasicFunctions.GetAllBooks();

            if (outputFormat == "CSV")
            {
                oh.WriteToCSV(allBooks);
            }
            else
            {
                oh.WriteToConsole(allBooks);
            }

            break;
        }
    case "GetBooksByAuthorLastName":
        {
            if (_args.Length > 3)
            {
                string lastName = _args[3];
                List<Book> booksByAuthor = BookStoreBasicFunctions.GetBooksByAuthorLastName(lastName);

                if (outputFormat == "CSV")
                {
                    oh.WriteToCSV(booksByAuthor);
                }
                else
                {
                    oh.WriteToConsole(booksByAuthor);
                }
            }
            else
            {
                Console.WriteLine("Missing author's last name for GetBooksByAuthorLastName.");
            }

            break;
        }
    
    default:
        {
            Console.WriteLine($"Unknown method name: {methodName}");

            break;
        }
}