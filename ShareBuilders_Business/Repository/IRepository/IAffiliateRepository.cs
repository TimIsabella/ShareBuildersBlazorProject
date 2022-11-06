using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IAffiliateRepository
	{
		public Affiliate Create(Affiliate obj);
		public Affiliate GetById(int id);
		public List<Affiliate> GetAll();
		public Affiliate Update(Affiliate obj);
		public int Delete(int id);
	}
}
