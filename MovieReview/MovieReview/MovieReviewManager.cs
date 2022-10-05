using MovieReview.Entities;
using MovieReview.Interface;
using MovieReview.Utility;

namespace MovieReview
{
    public class MovieReviewManager : IMovieReviewManager
    {

        private List<Review> allData;

        public MovieReviewManager(List<Review> data)
        {
            if (data == null)
            {
                throw new NullReferenceException("Missing repository");
            }
            allData = data;
            JsonReviewRepo json = new JsonReviewRepo();
            allData = json.reviews;
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            int reviews = 0;
            foreach (Review review in allData)
            {
                _ = review.reviewer == reviewer ? reviews++ : reviews + 0;
            }

            return reviews;
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            int reviews = 0;
            double averageRate = 0;
            foreach (Review review in allData)
            {
                _ = review.reviewer == reviewer ? reviews++ : reviews + 0;
                _ = review.reviewer == reviewer ? averageRate = averageRate + review.grade : reviews + 0;
            }
            averageRate = averageRate / reviews;
            return averageRate;
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            int rates = 0;
            foreach (Review review in allData)
            {
                _ = review.reviewer == reviewer && review.grade == rate ? rates++ : rates + 0;
            }
            return rates;
        }

        public int GetNumberOfReviews(int movie)
        {
            int reviews = 0;
            foreach (Review review in allData)
            {
                _ = review.movie == movie ? reviews++ : reviews + 0;
            }

            return reviews;
        }

        public double GetAverageRateOfMovie(int movie)
        {
            int reviews = 0;
            double averageRate = 0;
            foreach (Review review in allData)
            {
                _ = review.movie == movie ? reviews++ : reviews + 0;
                _ = review.movie == movie ? averageRate = averageRate + review.grade : reviews + 0;
            }
            averageRate = averageRate / reviews;
            return Math.Truncate(averageRate * 100) / 100;
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            int rates = 0;
            foreach (Review review in allData)
            {
                _ = review.movie == movie && review.grade == rate ? rates++ : rates + 0;
            }
            return rates;
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            int i = 0;
            List<int> movies = new List<int>();
            List<Review> sortedList = allData.OrderBy(o => o.grade).ToList();
            foreach (Review review in sortedList)
            {
                i++;
                Review temp = review;
                if (temp.movie == sortedList[i].movie)
                {

                }
            }
            return movies;
        }

        public List<int> GetMostProductiveReviewers()
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }
    }
}