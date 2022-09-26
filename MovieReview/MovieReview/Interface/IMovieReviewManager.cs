using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Interface
{
    public interface IMovieReviewManager
    {
        /// <summary>
        /// On input N, what are the number of reviews from reviewer N?
        /// </summary>
        int GetNumberOfReviewsFromReviewer(int reviewer);

        /// <summary>
        /// On input N, what is the average rate that reviewer N had given?
        /// </summary>
        double GetAverageRateFromReviewer(int reviewer);

        /// <summary>
        /// On input N and R, how many times has reviewer N given rate R?
        /// </summary>
        int GetNumberOfRatesByReviewer(int reviewer, int rate);

        /// <summary>
        /// On input N, how many have reviewed movie N?
        /// </summary>
        int GetNumberOfReviews(int movie);

        /// <summary>
        /// On input N, what is the average rate the movie N had received?
        /// </summary>
        double GetAverageRateOfMovie(int movie);

        /// <summary>
        /// On input N and R, how many times had movie N received rate R?
        /// </summary>
        int GetNumberOfRates(int movie, int rate);

        ///<summary>
        /// What is the id(s) of the movie(s) with the highest number of top rates (5)?
        /// </summary>
        List<int> GetMoviesWithHighestNumberOfTopRates();

        /// <summary>
        /// What reviewer(s) had done most reviews?
        /// </summary>
        /// <returns></returns>
        List<int> GetMostProductiveReviewers();

        /// <summary>
        /// On input N, what is top N of movies? The score of a movie is its average rate.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        List<int> GetTopRatedMovies(int amount);

        /// <summary>
        /// On input N, what are the movies that reviewer N has reviewed? The list should be sorted decreasing by rate first, and date secondly.
        /// </summary>
        /// <param name="reviewer"></param>
        /// <returns></returns>
        List<int> GetTopMoviesByReviewer(int reviewer);

        /// <summary>
        /// On input N, who are the reviewers that have reviewed movie N? The list should be sorted decreasing by rate first, and date secondly.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        List<int> GetReviewersByMovie(int movie);

    }
}
