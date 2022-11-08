using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_Models.BlazorModels
{
	public class StationUiDTO
	{
		public int Id { get; set; }
		public string CallLetters { get; set; }
		public string Owner { get; set; }
		public string Format { get; set; }
		public List<Affiliate> AffiliatesAssigned { get; set; }
		public List<BroadcastType> BroadcastTypesAssigned { get; set; }
		public List<Market> MarketsAssigned { get; set; }
	}
}