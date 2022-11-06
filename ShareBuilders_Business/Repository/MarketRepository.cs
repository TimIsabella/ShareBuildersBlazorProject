using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;
using System.Xml.Linq;

namespace ShareBuildersProject_Business.Repository
{
	public class MarketRepository : IMarketRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public MarketRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Market Create(Market obj)
		{
			Market newMarket = new Market()
			{
				Name = obj.Name,
				State = obj.State
			};

			_dbContext.Markets.Add(newMarket);
			_dbContext.SaveChanges();

			return newMarket;
		}

		public List<Market> GetAll()
		{
			var marketList = _dbContext.Markets.ToList();

			return marketList;
		}

		public Market GetById(int id)
		{
			var market = _dbContext.Markets.First(element => element.Id == id);

			if(market != null)
			{
				return market;
			}
			else return new Market();
		}

		public Market Update(Market obj)
		{
			var market = _dbContext.Users.First(element => element.Id == obj.Id);

			if(market != null)
			{
				Market updatedMarket = new Market()
				{
					Id = market.Id,
					Name = obj.Name,
					State = obj.State
				};

				_dbContext.Markets.Update(updatedMarket);
				_dbContext.SaveChanges();

				return updatedMarket;
			}
			else return obj;
		}

		public int Delete(int id)
		{
			var market = _dbContext.Markets.First(element => element.Id == id);

			if(market != null)
			{
				_dbContext.Markets.Remove(market);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
