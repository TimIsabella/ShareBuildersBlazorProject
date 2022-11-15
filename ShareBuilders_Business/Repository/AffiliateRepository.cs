using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository
{
	public class AffiliateRepository : IAffiliateRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public AffiliateRepository(ApplicationDbContext dbContext)
		{ _dbContext = dbContext; }

		public Affiliate Create(Affiliate obj)
		{
			Affiliate newAffiliate = new Affiliate()
			{
				Name = obj.Name,
				ShortName = obj.ShortName,
				City = obj.City,
				State = obj.State
			};

			_dbContext.Affiliates.Add(newAffiliate);
			_dbContext.SaveChanges();

			return newAffiliate;
		}

		public List<Affiliate> GetAll()
		{
			var affiliateList = _dbContext.Affiliates.ToList();
			return affiliateList;
		}

		public Affiliate GetById(int id)
		{
			var affiliate = _dbContext.Affiliates.Find(id);

			if(affiliate != null)
			{ return affiliate; }
			else
			{ return new Affiliate(); }
		}

		public Affiliate Update(Affiliate obj)
		{
			var affiliate = _dbContext.Affiliates.Find(obj.Id);

			if(affiliate != null)
			{
				affiliate.Name = obj.Name;
				affiliate.ShortName = obj.ShortName;
				affiliate.City = obj.City;
				affiliate.State = obj.State;

				_dbContext.Affiliates.Update(affiliate);
				_dbContext.SaveChanges();

				return affiliate;
			}
			else
			{ return obj; }
		}

		public int Delete(int id)
		{
			var affiliate = _dbContext.Affiliates.Find(id);

			if(affiliate != null)
			{
				_dbContext.Affiliates.Remove(affiliate);
				return _dbContext.SaveChanges();
			}
			else
			{ return 0; }
		}
	}
}
