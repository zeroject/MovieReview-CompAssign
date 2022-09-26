using MovieReview;
using MovieReview.Entities;

namespace MovieReviewTest
{
    public class UMovieReview
    {
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

        [Theory]
        [InlineData(852327, 3.57)]
        [InlineData(205228, 3.75)]
        [InlineData(94150,  3.25)]
        [InlineData(8309,   3.57)]
        public void TestGetAverageRateOfMovie(int movie, double expected)
        {
            //Arrange
            var movieReviewManager = new MovieReviewManager();

            //Act
            double averageData = movieReviewManager.GetAverageRateOfMovie(movie);

            //Assert
            Assert.Equal(expected, averageData);
        }
    }
}