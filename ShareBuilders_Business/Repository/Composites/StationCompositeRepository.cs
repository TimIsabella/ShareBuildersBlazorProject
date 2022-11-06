using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.Composites
{
	public class StationCompositeRepository : IStationCompositeRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public StationCompositeRepository(ApplicationDbContext dbContext)
		{ _dbContext = dbContext; }

		/// /////////// Affiliate /////////// ///
		public List<AffiliateComposite> CreateAffiliate(int stationId, int[] affiliateIds)
		{
			var list = new List<AffiliateComposite>();

			foreach(int affiliateId in affiliateIds)
			{ 
				list.Add(
					new AffiliateComposite()
					{
						StationId = stationId,
						AffiliateId = affiliateId
					});
			}

			_dbContext.AffiliateComposites.AddRange(list);
			_dbContext.SaveChanges();

			return list;
		}

		public List<AffiliateComposite> GetAllAffiliates()
		{
			var list = _dbContext.AffiliateComposites.ToList();
			return list;
		}

		public int DeleteAffiliate(int stationId)
		{
			var list = _dbContext.AffiliateComposites.Where(element => element.StationId == stationId).ToList();

			if(list != null)
			{
				_dbContext.AffiliateComposites.RemoveRange(list);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}

		/// /////////// Broadcast Type /////////// ///
		public List<BroadcastTypeComposite> CreateBroadcastType(int stationId, int[] BroadcastTypeIds)
		{
			var list = new List<BroadcastTypeComposite>();

			foreach(int BroadcastTypeId in BroadcastTypeIds)
			{
				list.Add(
					new BroadcastTypeComposite()
					{
						StationId = stationId,
						BroadcastTypeId = BroadcastTypeId
					});
			}

			_dbContext.BroadcastTypeComposites.AddRange(list);
			_dbContext.SaveChanges();

			return list;
		}

		public List<BroadcastTypeComposite> GetAllBroadcastTypes()
		{
			var list = _dbContext.BroadcastTypeComposites.ToList();
			return list;
		}

		public int DeleteBroadcastType(int stationId)
		{
			var list = _dbContext.BroadcastTypeComposites.Where(element => element.StationId == stationId).ToList();

			if(list != null)
			{
				_dbContext.BroadcastTypeComposites.RemoveRange(list);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}

		/// /////////// Market /////////// ///
		public List<MarketComposite> CreateMarket(int stationId, int[] marketIds)
		{
			var list = new List<MarketComposite>();

			foreach(int marketId in marketIds)
			{
				list.Add(
					new MarketComposite()
					{
						StationId = stationId,
						MarketId = marketId
					});
			}

			_dbContext.MarketComposites.AddRange(list);
			_dbContext.SaveChanges();

			return list;
		}

		public List<MarketComposite> GetAllMarket()
		{
			var list = _dbContext.MarketComposites.ToList();
			return list;
		}

		public int DeleteMarket(int stationId)
		{
			var list = _dbContext.MarketComposites.Where(element => element.StationId == stationId).ToList();

			if(list != null)
			{
				_dbContext.MarketComposites.RemoveRange(list);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
