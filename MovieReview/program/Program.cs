// See https://aka.ms/new-console-template for more information

using MovieReview.Utility;

JsonReviewRepo repo = new JsonReviewRepo(new StreamReader("C:\\Users\\kaspe\\Desktop\\sims\\MovieReview-CompAssign\\MovieReview\\MovieReview\\ratings.json"));
Console.WriteLine("first entry: " + repo.reviews[0].reviewer);
