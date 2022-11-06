using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business.Repository.IRepository;

namespace ShareBuildersProjectWeb_Api.Controllers
{
	public class UserController : ControllerBase
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserCompositeRepository _userCompositeRepository;

		public UserController(IUserRepository userRepository, IUserCompositeRepository userCompositeRepository)
		{
			_userRepository = userRepository;
			_userCompositeRepository = userCompositeRepository;
		}


	}
}
