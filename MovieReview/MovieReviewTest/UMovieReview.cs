using Microsoft.VisualBasic;
using MovieReview;
using MovieReview.Entities;
using MovieReview.Interface;

namespace MovieReviewTest
{
    public class UMovieReview
    {
        // Test 1
        [Theory]
        [InlineData(1, 4)]
        [InlineData(12, 5)]
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

        //Test 7
        [Fact]
        public void TestGetMoviesWithHighestNumberOfTopRates()
        {
            //Arrange
            int d = 0;
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();
            List<int> movieTopList = new List<int> { 8309, 94150, 852327, 1356096 };
            //act
            List<int> result = movieReviewManager.GetMoviesWithHighestNumberOfTopRates();
            foreach (int i in result)
            {
                if (i.Equals(movieTopList[i]))
                {
                    d++;
                }
            }
            Assert.Equal(4, d);
        }
        //Test 8
        [Fact]
        public void TestGetMostProductiveReviewers()
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();
            List<int> reviewerTopList = new List<int> { 12 };
            //act
            List<int> result = movieReviewManager.GetMostProductiveReviewers();
            foreach (int i in result)
            {
                Assert.Equal(reviewerTopList[i], i);
            }
        }
        //Test 9
        [Theory]
        [InlineData(4)]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(3)]
        public void TestGetTopRatedMovies(int amount)
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();
            //Movies sorted efter højest avg rating
            List<int> movieTopList = new List<int> 
            {1356096,2038901,1874239,
             1465002,577103,1564770 ,
             2643933,1894937,2281128,
             1792480,2156834,205228 ,
             852327,8309,94150      ,
             1251664,87062,2111120  ,
             1054564,2503089,1763064,
             1555901,1993625        };
            //act
            List<int> expected = movieTopList.GetRange(0, amount);
            List<int> result = movieReviewManager.GetTopRatedMovies(amount);
            foreach (int i in result)
            {
                Assert.Equal(expected[i], i);
            }
        }
        //Test 10
        [Fact]
        public void TestGetTopMoviesByReviewer()
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();
            List<int> movieTopList = new List<int> {1564770, 87062, 205228, 1251664};
            //act
            List<int> result = movieReviewManager.GetTopMoviesByReviewer(7);
            foreach (int i in result)
            {
                Assert.Equal(movieTopList[i], i);
            }
        }
        //Test 11
        [Fact]
        public void TestGetReviewersByMovie()
        {
            //Arrange
            IMovieReviewManager movieReviewManager;
            movieReviewManager = new MovieReviewManager();
            List<int> movieTopList = new List<int> {12,5,4,3,1,6};
            //act
            List<int> result = movieReviewManager.GetReviewersByMovie(94150);
            foreach (int i in result)
            {
                Assert.Equal(movieTopList[i], i);
            }
        }

        /// <summary>
        /// ---------Error Tests----------
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