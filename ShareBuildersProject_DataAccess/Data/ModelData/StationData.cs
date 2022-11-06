using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data.ModelData
{
    public static class StationData
    {
        public static List<Station> Data = new List<Station>
        {
            new Station
            {
                Id = 1,
                CallLetters = "KTLA",
                Owner = "Nextar Media Group",
                Format = "Local Television"
            },

            new Station
            {
                Id = 2,
                CallLetters = "KABC",
                Owner = "ABC Owned Television Stations",
                Format = "Local Television"
            },

            new Station
            {
                Id = 3,
                CallLetters = "KSNE",
                Owner = "IHeartMedia",
                Format = "Adult Contemporary"
            },
        };
    }
}
