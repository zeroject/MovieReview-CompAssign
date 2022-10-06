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
            List<Review> sortedList = allData.OrderBy(o => o.grade).ToList();
            Dictionary<int, int> rateMap = new Dictionary<int, int>();
            foreach (Review item in sortedList)
            {
                if (item.grade == 5 && !rateMap.ContainsKey(item.movie))
                {
                    rateMap.Add(item.movie, 1);
                } else if (item.grade == 5)
                {
                    rateMap[item.movie]++;
                }
            }
            rateMap.OrderBy(o => o.Value);
            return rateMap.Select(o => o.Key).ToList();
        }

        public List<int> GetMostProductiveReviewers()
        {
            Dictionary<int, int> rateMap = new Dictionary<int, int>();
            int[] filter;
            List<int> result = new List<int>();
            foreach (Review item in allData)
            {
                if (!rateMap.ContainsKey(item.reviewer))
                {
                    rateMap.Add(item.reviewer, 1);
                }
                else
                {
                    rateMap[item.reviewer]++;
                }
            }
            rateMap.OrderBy(o => o.Value);
            
            filter = rateMap.Select(o => o.Key).ToArray();
            if (filter[0] == filter[1])
            {
                result.Add(filter[0]);
                result.Add(filter[1]);
                return result;
            }
            else { result.Add(filter[0]); }
            return result;
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            List<int> temp = new List<int>();
            List<Review> sortedList = allData.OrderBy(o => o.grade).ToList();
            Dictionary<int, int> rateMap = new Dictionary<int, int>();
            foreach (Review item in sortedList)
            {
                if (item.grade == 5 && !rateMap.ContainsKey(item.movie))
                {
                    rateMap.Add(item.movie, 1);
                }
                else if (item.grade == 5)
                {
                    rateMap[item.movie]++;
                }
            }
            rateMap.OrderBy(o => o.Value);
            temp = rateMap.Select(o => o.Key).ToList();
            return temp.GetRange(0, amount);
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            List<Review> sortedList = allData.OrderBy(o => o.grade).ToList();
            Dictionary<int, int> rateMap = new Dictionary<int, int>();
            foreach (Review item in sortedList)
            {
                if (item.reviewer == reviewer)
                {
                    rateMap.Add(item.movie, item.grade);
                }
            }
            rateMap.OrderBy(o => o.Value);
            return rateMap.Select(o => o.Key).ToList();
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            List<Review> sortedList = allData.OrderBy(o => o.grade).ToList();
            Dictionary<int, int> rateMap = new Dictionary<int, int>();
            foreach (Review item in sortedList)
            {
                if (item.movie == movie)
                {
                    rateMap.Add(item.reviewer, item.grade);
                }
            }
            rateMap.OrderBy(o => o.Value);
            return rateMap.Select(o => o.Key).ToList();
        }
    }
}