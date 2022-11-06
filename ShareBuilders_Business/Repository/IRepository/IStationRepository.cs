using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Business.Repository.IRepository
{
	public interface IStationRepository
	{
		public Station Create(Station obj);
		public Station GetById(int id);
		public List<Station> GetAll();
		public Station Update(Station obj);
		public int Delete(int id);
	}
}
