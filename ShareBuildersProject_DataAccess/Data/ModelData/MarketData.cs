using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data.ModelData
{
    public static class MarketData
    {
        public static List<Market> Data = new List<Market>
        {
            new Market
            {
                Id = 1,
                Name = "New York",
                State = "New York"
            },

            new Market
            {
                Id = 2,
                Name = "Los Angeles",
                State = "California"
            },

            new Market
            {
                Id = 3,
                Name = "Las Vegas",
                State = "Nevada"
            },
        };
    }
}
