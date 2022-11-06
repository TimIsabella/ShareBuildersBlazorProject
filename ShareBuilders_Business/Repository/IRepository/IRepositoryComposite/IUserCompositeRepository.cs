using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IUserCompositeRepository
	{
		public List<UserComposite> CreateUser(int userId, int[] stationIds);
		public List<UserComposite> GetAllUsers();
		public int DeleteUser(int id);
	}
}
