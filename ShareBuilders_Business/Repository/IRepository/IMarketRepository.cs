using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IMarketRepository
	{
		public Market Create(Market obj);
		public Market GetById(int id);
		public List<Market> GetAll();
		public Market Update(Market obj);
		public int Delete(int id);
	}
}
