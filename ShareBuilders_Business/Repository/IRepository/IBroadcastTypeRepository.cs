using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IBroadcastTypeRepository
	{
		public BroadcastType Create(BroadcastType obj);
		public BroadcastType GetById(int id);
		public List<BroadcastType> GetAll();
		public BroadcastType Update(BroadcastType obj);
		public int Delete(int id);
	}
}
