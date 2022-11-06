using Microsoft.AspNetCore.Mvc;
using ShareBuildersProject_Business;

namespace ShareBuildersProjectWeb_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private IUserRepository _userRepository;

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
	}
}
