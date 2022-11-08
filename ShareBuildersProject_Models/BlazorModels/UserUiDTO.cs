using System.Diagnostics.CodeAnalysis;

namespace ShareBuildersProject_Models.BlazorModels
{
	public class UserUiDTO
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime CreationDate { get; set; }
		public List<StationUiDTO> StationsAssigned { get; set; }
	}
}