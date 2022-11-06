using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data.ModelData
{
    public static class BroadcastTypeData
    {
        public static List<BroadcastType> Data = new List<BroadcastType>
        {
            new BroadcastType
            {
                Id = 1,
                Name = "Radio",
            },

            new BroadcastType
            {
                Id = 2,
                Name = "Television",
            },

            new BroadcastType
            {
                Id = 3,
                Name = "Streaming",
            }
        };
    }
}
