using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data.ModelData
{
    public static class AffiliateData
    {
        public static List<Affiliate> Data = new List<Affiliate>
        {
            new Affiliate
            {
                Id = 1,
                Name = "National Broadcasting Company",
                ShortName = "NBC",
                City = "New York City",
                State = "New York"
            },

            new Affiliate
            {
                Id = 2,
                Name = "American Broadcasting Company",
                ShortName = "ABC",
                City = "Burbank",
                State = "California"
            },

            new Affiliate
            {
                Id = 3,
                Name = "Columbia Broadcasting System",
                ShortName = "CBS",
                City = "New York City",
                State = "New York"
            },

            new Affiliate
            {
                Id = 4,
                Name = "British Broadcasting Corporation",
                ShortName = "BBC",
                City = "London",
                State = "England"
            },
        };
    }
}
