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
        public int reviewer;
        public int movie;
        public int grade;
        public DateTime reviewDate;
    }
}
