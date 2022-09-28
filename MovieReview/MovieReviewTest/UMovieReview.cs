using MovieReview;
using MovieReview.Entities;
using MovieReview.Interface;

namespace MovieReviewTest
{
    public class UMovieReview
    {
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

        //throw rounds 1
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
                movieReviewManager.GetNumberOfReviewsFromReviewer(13);
            }
            catch (Exception ex)
            {
                Assert.Equal(expected)
            }
                
                

        }



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