using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MovieReview.Entities;

namespace MovieReview.Utility
{
    public class JsonReviewRepo
    {
        public Review[] reviews { get; private set; }

        private TextReader _reader;


        /// <summary>
        /// it needs a streamReader with proper file location of a Json file
        /// </summary>
        /// <param name="reader"></param>
        public JsonReviewRepo(String fileLocation)
        {
            _reader = new StreamReader(fileLocation);
            reviews =  GetAllReviews();
        }

        private Review[] GetAllReviews()
        {
            List<Review> itemList = new List<Review>();
            using (JsonTextReader reader = new JsonTextReader(_reader))
            {
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        Review review = new Review();
                        reader.Read();
                        review.reviewer =(int)reader.ReadAsInt32();

                        reader.Read();
                        review.movie = (int)reader.ReadAsInt32();

                        reader.Read();
                        review.grade = (int)reader.ReadAsInt32();

                        reader.Read();
                        review.reviewDate = (DateTime)reader.ReadAsDateTime();
                        itemList.Add(review);
                    }
                }
                return itemList.ToArray();
            }
        }
    }
}
