using BlockBuster;
using Microsoft.EntityFrameworkCore;

namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]
        public void GetMovieByIdTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title == "Vertigo");
            Assert.True(result.ReleaseYear == 1958);
        }

        [Fact]
        public void GetAllMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 54);
        }

        [Fact]
        public void GetAllCheckedOutMovies()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

        [Fact]
        public static void GetMoviesByGenre()
        {
            var expectedGenre = "TEST";

            var result = BlockBusterBasicFunctions.GetMoviesByGenre(expectedGenre);

            Assert.All(result, m => Assert.Equal(expectedGenre, m.Genre.GenreDescr));
        }

        [Fact]
        public void GetMoviesByDirectorLastName()
        {
            var expectedLastName = "Nolan"; 

            var result = BlockBusterBasicFunctions.GetMoviesByDirectorLastName(expectedLastName);

            Assert.All(result, m => Assert.Equal(expectedLastName, m.Director.LastName));
        }

        [Fact]
        public void GetMovieByTitle()
        {
            var expectedTitle = "Raging Bull"; 

            var result = BlockBusterBasicFunctions.GetMovieByTitle(expectedTitle);

            Assert.Equal(expectedTitle, result.Title);
        }
    }
}
