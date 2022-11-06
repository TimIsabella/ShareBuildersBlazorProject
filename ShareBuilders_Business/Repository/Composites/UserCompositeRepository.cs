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

		public List<UserComposite> Create(int userId, int[] stationIds)
		{
			var list = new List<UserComposite>();

			foreach(int station in stationIds)
			{
				list.Add(
					new UserComposite()
					{
						UserId = userId,
						StationId = station
					});
			}

			_dbContext.UserComposites.AddRange(list);
			_dbContext.SaveChanges();

			return list;
		}

		public List<UserComposite> GetAll()
		{
			var list = _dbContext.UserComposites.ToList();
			return list;
		}

		public int Delete(int id)
		{
			var list = _dbContext.UserComposites.Where(element => element.UserId == id).ToList();

			if(list != null)
			{
				_dbContext.UserComposites.RemoveRange(list);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
