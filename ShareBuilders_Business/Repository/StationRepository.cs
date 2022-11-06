using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Data;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository
{
	public class StationRepository : IStationRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public StationRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Station Create(Station obj)
		{
			Station newStation = new Station()
			{
				CallLetters = obj.CallLetters,
				Owner = obj.Owner,
				Format = obj.Format
			};

			_dbContext.Stations.Add(newStation);
			_dbContext.SaveChanges();

			return newStation;
		}

		public List<Station> GetAll()
		{
			var stationList = _dbContext.Stations.ToList();

			return stationList;
		}

		public Station GetById(int id)
		{
			var station = _dbContext.Stations.First(element => element.Id == id);

			if(station != null)
			{
				return station;
			}
			else return new Station();
		}

		public Station Update(Station obj)
		{
			var station = _dbContext.Stations.First(element => element.Id == obj.Id);

			if(station != null)
			{
				Station updatedStation = new Station()
				{
					Id = station.Id,
					CallLetters = obj.CallLetters,
					Owner = obj.Owner,
					Format = obj.Format
				};

				_dbContext.Stations.Update(updatedStation);
				_dbContext.SaveChanges();

				return updatedStation;
			}
			else return obj;
		}

		public int Delete(int id)
		{
			var station = _dbContext.Stations.First(element => element.Id == id);

			if(station != null)
			{
				_dbContext.Stations.Remove(station);
				return _dbContext.SaveChanges();
			}
			else return 0;
		}
	}
}
