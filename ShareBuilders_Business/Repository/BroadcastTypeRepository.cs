using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository
{
	public class BroadcastTypeRepository : IBroadcastTypeRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public BroadcastTypeRepository(ApplicationDbContext dbContext)
		{ _dbContext = dbContext; }

		public BroadcastType Create(BroadcastType obj)
		{
			BroadcastType newBroadcastType = new BroadcastType()
			{
				Name = obj.Name,
			};

			_dbContext.BroadcastTypes.Add(newBroadcastType);
			_dbContext.SaveChanges();

			return newBroadcastType;
		}

		public List<BroadcastType> GetAll()
		{
			var broadcastTypeList = _dbContext.BroadcastTypes.ToList();
			return broadcastTypeList;
		}

		public BroadcastType GetById(int id)
		{
			var broadcastType = _dbContext.BroadcastTypes.Find(id);

			if(broadcastType != null)
			{ return broadcastType; }
			else
			{ return new BroadcastType(); }
		}

		public BroadcastType Update(BroadcastType obj)
		{
			var broadcastType = _dbContext.BroadcastTypes.Find(obj.Id);

			if(broadcastType != null)
			{
				broadcastType.Name = obj.Name;

				_dbContext.BroadcastTypes.Update(broadcastType);
				_dbContext.SaveChanges();

				return broadcastType;
			}
			else
			{ return obj; }
		}

		public int Delete(int id)
		{
			var broadcastType = _dbContext.BroadcastTypes.Find(id);

			if(broadcastType != null)
			{
				_dbContext.BroadcastTypes.Remove(broadcastType);
				return _dbContext.SaveChanges();
			}
			else
			{ return 0; }
		}
	}
}
