// See https://aka.ms/new-console-template for more information

using MovieReview.Entities;
using MovieReview.Utility;

JsonReviewRepo repo = new JsonReviewRepo(new StreamReader("C:\\Users\\kaspe\\Desktop\\sims\\MovieReview-CompAssign\\MovieReview\\MovieReview\\ratings.json"));

// Reviewer: 1, Movie: 1488844, Grade: 3, Date: '2005-09-06' 
Review review1 = new Review();
review1.reviewer = 1;
review1.movie = 1488844;
review1.grade = 3;
review1.reviewDate = new DateTime(2005, 9, 6);

// Reviewer:999, Movie:1559566, Grade:2, Date:'2005-09-26
Review review2 = new Review();
review2.reviewer = 999;
review2.movie = 1559566;
review2.grade = 2;
review2.reviewDate = new DateTime(2005, 9, 26);
Console.WriteLine("first movie: " + repo.reviews[0].movie + "is the same: " + (repo.reviews[0].movie == review1.movie ? true : false));
Console.WriteLine(repo.reviews.Length + "");
