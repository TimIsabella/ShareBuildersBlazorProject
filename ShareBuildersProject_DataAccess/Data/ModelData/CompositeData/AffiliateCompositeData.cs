
using ShareBuildersProject_DataAccess.Composite;

namespace ShareBuildersProject_DataAccess.ModelData.CompositeData
{
	public static class AffiliateCompositeData
	{
		public static List<AffiliateComposite> Data = new List<AffiliateComposite>
		{ 
			//Station 1
			new AffiliateComposite
			{
				StationId = 1,
				AffiliateId = 1
			},
			
			new AffiliateComposite
			{
				StationId = 1,
				AffiliateId = 2
			},

			new AffiliateComposite
			{
				StationId = 1,
				AffiliateId = 3
			},

			new AffiliateComposite
			{
				StationId = 1,
				AffiliateId = 4
			},

			//Station 2
			new AffiliateComposite
			{
				StationId = 2,
				AffiliateId = 2
			},

			new AffiliateComposite
			{
				StationId = 2,
				AffiliateId = 4
			},

			//Station 3
			new AffiliateComposite
			{
				StationId = 3,
				AffiliateId = 4
			}
		};
	}
}
