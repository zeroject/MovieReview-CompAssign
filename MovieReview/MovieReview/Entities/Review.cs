using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Entities
{
    /// <summary>
    /// Review holds a reviewer's id and a movie id and a grade and a date when the review was made
    /// </summary>
    public class Review
    {
        public int reviewer { get; set; }
        public int movie { get; set; }
        public int grade { get; set; }
        public DateTime reviewDate { get; set; }


        public Review(int reviewer, int movie, int grade, DateTime reviewDate)
        {
            this.reviewer = reviewer;
            this.movie = movie;
            this.grade = grade;
            this.reviewDate = reviewDate;
        }

        public Review()
        {

        }
    }
}
