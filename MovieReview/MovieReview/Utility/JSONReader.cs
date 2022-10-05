using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MovieReview.Entities;

namespace MovieReview.Utility
{
    public class JSONReader
    {
        string jsonFilePath = "..//..//..//..//ratings.json";

        public List<Review> JsonReviews()
        {
            using (StreamReader file = File.OpenText(jsonFilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                
            }
        }
    }
}
