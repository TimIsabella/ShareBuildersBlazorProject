using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.Composites
{
	public class UserCompositeRepository : IUserCompositeRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public UserCompositeRepository(ApplicationDbContext dbContext)
		{ _dbContext = dbContext; }

		public List<UserComposite> CreateUser(int userId, int[] stationIds)
		{
			var compositeList = new List<UserComposite>();

			foreach(int station in stationIds)
			{ 
				compositeList.Add(
					new UserComposite()
					{
						UserId = userId,
						StationId = station
					});
			}

			_dbContext.UserComposites.AddRange(compositeList);
			_dbContext.SaveChanges();

			return compositeList;
		}

		public List<UserComposite> GetAllUsers()
		{
			var userList = _dbContext.UserComposites.ToList();
			return userList;
		}

		public int DeleteUser(int id)
		{
			var user = _dbContext.UserComposites.Where(element => element.UserId == id).ToList();

			if(user != null)
			{
				_dbContext.UserComposites.RemoveRange(user);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
