
using ShareBuildersProject_DataAccess.Composite;

namespace ShareBuildersProject_DataAccess.ModelData.CompositeData
{
	public static class BroadcastTypeCompositeData
	{
		public static List<BroadcastTypeComposite> Data = new List<BroadcastTypeComposite>
		{ 
			//Station 1
			new BroadcastTypeComposite
			{
				StationId = 1,
				BroadcastTypeId = 2
			},
			
			new BroadcastTypeComposite
			{
				StationId = 1,
				BroadcastTypeId = 3
			},


			//Station 2
			new BroadcastTypeComposite
			{
				StationId = 2,
				BroadcastTypeId = 2
			},

			//Station 3
			new BroadcastTypeComposite
			{
				StationId = 3,
				BroadcastTypeId = 1
			}
		};
	}
}
