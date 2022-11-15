using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Services
{
	public class MarketService
	{
		private readonly IMarketRepository _marketRepository;

		public MarketService(IMarketRepository marketRepository)
		{ _marketRepository = marketRepository; }

		public Market CreateMarket(Market marketData)
		{ return _marketRepository.Create(marketData); }

		public IEnumerable<Market> GetAllMarkets()
		{ return _marketRepository.GetAll(); }

		public Market GetMarketById(int id)
		{ return _marketRepository.GetById(id); }

		public Market Update(Market marketData)
		{ return _marketRepository.Update(marketData); }

		public int Delete(int id)
		{ return _marketRepository.Delete(id); }
	}
}
