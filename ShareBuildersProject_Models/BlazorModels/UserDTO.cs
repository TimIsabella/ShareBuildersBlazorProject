using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_Models.BlazorModels
{
	public class UserDTO
	{
		public int? Id { get; set; }

		[Required]
		[Range(1, 50)]
		public string FirstName { get; set; }

		[Required]
		[Range(1, 50)]
		public string LastName { get; set; }

		public int[]? StationIds { get; set; }
	}
}