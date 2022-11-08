using ShareBuildersProject_Business.Repository.IRepository;
using ShareBuildersProject_DataAccess.Models;
using ShareBuildersProject_Models.BlazorModels;

namespace ShareBuildersProjectWeb_Api.Services
{
	public class UserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserCompositeRepository _userCompositeRepository;
		private readonly IStationRepository _stationRepository;

		public UserService(IUserRepository userRepository, IUserCompositeRepository userCompositeRepository, IStationRepository stationRepository)
		{
			_userRepository = userRepository;
			_userCompositeRepository = userCompositeRepository;
			_stationRepository = stationRepository;
		}

		public User CreateUser(UserAddUpdateDTO userData)
		{
			User newUser = new User()
			{
				FirstName = userData.FirstName,
				LastName = userData.LastName,
			};

			var result = _userRepository.Create(newUser);

			if (result.Id != null && userData.StationIds != null)
			{ _userCompositeRepository.Create((int)result.Id, userData.StationIds); }

			return result;
		}

		public User GetUserById(int id)
		{
			var result = _userRepository.GetById(id);
			return result;
		}

		public IEnumerable<User> GetAllUsers()
		{
			var result = _userRepository.GetAll();
			return result;
		}

		public IEnumerable<UserUiDTO> GetAllUsersAssignedToStations()
		{
			var result = from user in _userRepository.GetAll()
						 select new UserUiDTO()
						 {
							 Id = (int)user.Id,
							 FirstName = user.FirstName,
							 LastName = user.LastName,
							 StationsAssigned = (from userComp in _userCompositeRepository.GetAll()
												 where user.Id == userComp.UserId
												 join station in _stationRepository.GetAll()
												 on userComp.StationId equals station.Id
												 select new StationUiDTO()
												 {
													 Id = (int)station.Id,
													 CallLetters = station.CallLetters,
													 Owner = station.Owner,
													 Format = station.Format
												 }).ToList(),

							 CreationDate = (DateTime) user.CreationDate
						 };

			return result;
		}

		public User Update(UserAddUpdateDTO userData)
		{
			User updatedUser = new User()
			{
				Id = userData.Id,
				FirstName = userData.FirstName,
				LastName = userData.LastName,
			};

			var result = _userRepository.Update(updatedUser);

			if (result.CreationDate != null && userData.StationIds != null)
			{
				_userCompositeRepository.Delete((int)userData.Id);
				_userCompositeRepository.Create((int)result.Id, userData.StationIds);
			}

			return result;
		}

		public int Delete(int id)
		{
			var result = _userRepository.Delete(id);
			_userCompositeRepository.Delete(id);

			return result;
		}
	}
}
