
using ShareBuildersProject_DataAccess.Composite;

namespace ShareBuildersProject_DataAccess.ModelData.CompositeData
{
	public static class MarketCompositeData
	{
		public static List<MarketComposite> Data = new List<MarketComposite>
		{ 
			//Station 1
			new MarketComposite
			{
				StationId = 1,
				MarketId = 2
			},
			
			new MarketComposite
			{
				StationId = 1,
				MarketId = 3
			},


			//Station 2
			new MarketComposite
			{
				StationId = 2,
				MarketId = 1
			},

			new MarketComposite
			{
				StationId = 2,
				MarketId = 2
			},

			new MarketComposite
			{
				StationId = 2,
				MarketId = 3
			},

			//Station 3
			new MarketComposite
			{
				StationId = 3,
				MarketId = 3
			}
		};
	}
}
