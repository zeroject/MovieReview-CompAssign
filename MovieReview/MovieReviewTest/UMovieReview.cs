using MovieReview;
using MovieReview.Entities;
using MovieReview.Interface;

namespace MovieReviewTest
{
    public class UMovieReview
    {
        // Test 1
        [Theory]
        [InlineData(1,4)]
        [InlineData(12,5)]
        public void TestGetNumberOfReviewsFromReviewer(int reviewID, int result)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();

            //Act
            int actionResult = movieReviewManager.GetNumberOfReviewsFromReviewer(reviewID);

            //Assert
            Assert.True(actionResult == result);
        }

        // Test 2
        [Theory]
        [InlineData(1, 3.75)]
        [InlineData(2, 3.25)]
        [InlineData(3, 3.00)]
        [InlineData(4, 3.25)]
        public void TestGetAverageRateFromReviewer(int reviewer, double expected)
        {
            //Arrange
            var movieReviewManager = new MovieReviewManager();

            //Act
            double averageData = movieReviewManager.GetAverageRateFromReviewer(reviewer);

            //Assert
            Assert.Equal(expected, averageData);
        }

        // Test 3
        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(5, 5, 2)]
        [InlineData(7, 1, 0)]
        public void TestGetNumberOfRatesByReviewer(int reviewer, int rate, int expected)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();

            //act
            int amount = movieReviewManager.GetNumberOfRatesByReviewer(reviewer, rate);

            //Assert
            Assert.Equal(expected, amount);
        }

        // Test 4
        [Theory]
        [InlineData(852327, 7)]
        [InlineData(205228, 8)]
        public void TestGetNumberOfReviews(int movie, int expected)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();

            //act
            int amount = movieReviewManager.GetNumberOfReviews(movie);

            //assert
            Assert.Equal(expected, amount);
        }

        // Test 5
        [Theory]
        [InlineData(852327, 3.57)]
        [InlineData(205228, 3.75)]
        [InlineData(94150, 3.25)]
        [InlineData(8309, 3.57)]
        public void TestGetAverageRateOfMovie(int movie, double expected)
        {
            //Arrange
            var movieReviewManager = new MovieReviewManager();

            //Act
            double averageData = movieReviewManager.GetAverageRateOfMovie(movie);

            //Assert
            Assert.Equal(expected, averageData);
        }

        // Test 6
        [Theory]
        [InlineData(205228, 4, 4)]
        [InlineData(1555901, 5, 0)]
        public void TestGetNumberOfRates(int movie, int rate, int expected)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();

            //act
            int amount = movieReviewManager.GetNumberOfRates(movie, rate);

            //assert
            Assert.Equal(expected, amount);
        }

        //Test 7 NOT DONE
        [Fact]
        public void TestGetMoviesWithHighestNumberOfTopRates()
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager= new MovieReviewManager();
            List<int> movieTopList = new List<int> { 852327, 94150, 8309, 1356096 };

            //act

        }


        /// <summary>
        /// Error Tests
        /// </summary>

        // Test 1.1
        [Theory]
        [InlineData(int.MaxValue, typeof(ArgumentException))]
        [InlineData(0, typeof(ArgumentException))]
        [InlineData(int.MinValue, typeof(ArgumentException))]
        public void TestGetNumberOfReviewsFromReviewerThrows(int reviewID, Type expected)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();

            //Act && Assert

            try
            {
                movieReviewManager.GetNumberOfReviewsFromReviewer(reviewID);
            }
            catch (Exception e)
            {
                Assert.Equal(expected, e.GetType());
            }
        }
    }
}