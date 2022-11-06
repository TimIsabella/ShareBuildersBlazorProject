
using ShareBuildersProject_DataAccess.Composite;

namespace ShareBuildersProject_DataAccess.ModelData.CompositeData
{
	public static class UserCompositeData
	{
		public static List<UserComposite> Data = new List<UserComposite>
		{ 
			//User 1
			new UserComposite
			{
				UserId = 1,
				StationId = 1
			},
			
			new UserComposite
			{
				UserId = 1,
				StationId = 2
			},

			new UserComposite
			{
				UserId = 1,
				StationId = 3
			},

			//User 2
			new UserComposite
			{
				UserId = 2,
				StationId = 1
			},

			new UserComposite
			{
				UserId = 2,
				StationId = 3
			},

			//User 3
			new UserComposite
			{
				UserId = 3,
				StationId = 2
			}
		};
	}
}
