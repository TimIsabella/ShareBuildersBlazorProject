using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data.ModelData
{
	public static class UserData
	{
		public static List<User> Data = new List<User>
		{
			new User
			{
				Id = 1,
				FirstName = "Mike",
				LastName = "Jones",
				CreationDate = DateTime.Now,
			},

			new User
			{
				Id = 2,
				FirstName = "Bob",
				LastName = "Smith",
				CreationDate = DateTime.Now,
			},

			new User
			{
				Id = 3,
				FirstName = "Sarah",
				LastName = "Parker",
				CreationDate = DateTime.Now,
			},
		};
	}
}
