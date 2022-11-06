using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IStationCompositeRepository
	{
		//Affiliate
		public List<AffiliateComposite> CreateAffiliate(int stationId, int[] AffiliateIds);
		public List<AffiliateComposite> GetAllAffiliates();
		public int DeleteAffiliate(int stationId);

		//BroadcastType
		public List<BroadcastTypeComposite> CreateBroadcastType(int stationId, int[] BroadcastTypeIds);
		public List<BroadcastTypeComposite> GetAllBroadcastTypes();
		public int DeleteBroadcastType(int stationId);

		//Market
		public List<MarketComposite> CreateMarket(int stationId, int[] MarketId);
		public List<MarketComposite> GetAllMarket();
		public int DeleteMarket(int stationId);
	}
}
