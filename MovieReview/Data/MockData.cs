using MovieReview.Entities;

namespace Data
{
    public static class MockData
    {
        public static List<object> GetData()
        {
            var allData = new List<object>
            {
                new object[] { new Review(1,  852327,  4, new DateTime(2005-10-30))},
                new object[] { new Review(1,  205228,  4, new DateTime(2005-10-31))},
                new object[] { new Review(1,  94150,   2, new DateTime(2005-11-02))},
                new object[] { new Review(1,  8309,    5, new DateTime(2005-11-07))},
                new object[] { new Review(2,  852327,  1, new DateTime(2005-11-12))},
                new object[] { new Review(2,  8309,    4, new DateTime(2005-11-20))},
                new object[] { new Review(2,  205228,  4, new DateTime(2005-11-21))},
                new object[] { new Review(2,  1465002, 4, new DateTime(2005-11-15))},
                new object[] { new Review(3,  1555901, 1, new DateTime(2005-11-23))},
                new object[] { new Review(3,  852327,  4, new DateTime(2005-11-28))},
                new object[] { new Review(3,  1356096, 5, new DateTime(2005-12-04))},
                new object[] { new Review(3,  94150,   2, new DateTime(2005-12-04))},
                new object[] { new Review(4,  2503089, 2, new DateTime(2005-12-04))},
                new object[] { new Review(4,  205228,  4, new DateTime(2005-12-11))},
                new object[] { new Review(4,  94150,   4, new DateTime(2005-07-05))},
                new object[] { new Review(4,  852327,  3, new DateTime(2005-07-06))},
                new object[] { new Review(5,  94150,   5, new DateTime(2004-04-17))},
                new object[] { new Review(5,  2038901, 5, new DateTime(2004-06-14))},
                new object[] { new Review(5,  205228,  4, new DateTime(2004-08-20))},
                new object[] { new Review(5,  94150,   3, new DateTime(2004-04-29))},
                new object[] { new Review(6,  577103,  4, new DateTime(2004-04-21))},
                new object[] { new Review(6,  852327,  5, new DateTime(2005-07-08))},
                new object[] { new Review(6,  205228,  5, new DateTime(2005-07-09))},
                new object[] { new Review(6,  94150,   1, new DateTime(2004-05-25))},
                new object[] { new Review(7,  1564770, 4, new DateTime(2005-07-12))},
                new object[] { new Review(7,  1251664, 3, new DateTime(2004-04-22))},
                new object[] { new Review(7,  205228,  3, new DateTime(2005-07-12))},
                new object[] { new Review(7,  87062,   3, new DateTime(2005-07-13))},
                new object[] { new Review(8,  1874239, 5, new DateTime(2004-04-10))},
                new object[] { new Review(8,  2643933, 4, new DateTime(2004-04-23))},
                new object[] { new Review(8,  1763064, 2, new DateTime(2004-07-11))},
                new object[] { new Review(8,  1894937, 4, new DateTime(2004-07-08))},
                new object[] { new Review(9,  205228,  3, new DateTime(2004-05-25))},
                new object[] { new Review(9,  2281128, 4, new DateTime(2004-05-04))},
                new object[] { new Review(9,  8309,    3, new DateTime(2005-07-16))},
                new object[] { new Review(9,  2111120, 3, new DateTime(2004-07-10))},
                new object[] { new Review(10, 1792480, 4, new DateTime(2004-06-01))},
                new object[] { new Review(10, 8309,    3, new DateTime(2004-07-22))},
                new object[] { new Review(10, 8309,    4, new DateTime(2004-08-30))},
                new object[] { new Review(10, 205228,  3, new DateTime(2004-05-01))},
                new object[] { new Review(11, 8309,    3, new DateTime(2004-09-01))},
                new object[] { new Review(11, 8309,    3, new DateTime(2005-07-22))},
                new object[] { new Review(11, 852327,  3, new DateTime(2004-07-01))},
                new object[] { new Review(11, 1054564, 3, new DateTime(2004-04-23))},
                new object[] { new Review(12, 2156834, 4, new DateTime(2004-09-07))},
                new object[] { new Review(12, 1993625, 1, new DateTime(2004-04-14))},
                new object[] { new Review(12, 94150,   4, new DateTime(2004-08-10))},
                new object[] { new Review(12, 852327,  5, new DateTime(2004-09-04))},
                new object[] { new Review(12, 94150,   5, new DateTime(2004-07-01))},
            };
            return allData;
        }

    }
}