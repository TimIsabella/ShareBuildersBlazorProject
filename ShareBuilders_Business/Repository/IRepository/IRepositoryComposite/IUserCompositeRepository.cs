using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IUserCompositeRepository
	{
		public List<UserComposite> Create(int userId, int[] stationIds);
		public List<UserComposite> GetAll();
		public int Delete(int id);
	}
}
