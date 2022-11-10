using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProjectWeb_Api.Services
{
	public class BroadcastTypeService
	{
		private readonly IBroadcastTypeRepository _broadcastTypeRepository;

		public BroadcastTypeService(IBroadcastTypeRepository broadcastTypeRepository)
		{ _broadcastTypeRepository = broadcastTypeRepository; }

		public BroadcastType CreateBroadcastType(BroadcastType broadcastTypeData)
		{
			return _broadcastTypeRepository.Create(broadcastTypeData);
		}

		public IEnumerable<BroadcastType> GetAllBroadcastTypes()
		{
			return _broadcastTypeRepository.GetAll();
		}

		public BroadcastType GetBroadcastTypeById(int id)
		{
			return _broadcastTypeRepository.GetById(id);
		}

		public BroadcastType Update(BroadcastType broadcastTypeData)
		{
			return _broadcastTypeRepository.Update(broadcastTypeData);
		}

		public int Delete(int id)
		{
			return _broadcastTypeRepository.Delete(id);
		}
	}
}
