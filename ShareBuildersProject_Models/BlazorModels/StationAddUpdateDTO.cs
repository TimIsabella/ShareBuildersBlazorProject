
using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_Models.BlazorModels
{
	public class StationAddUpdateDTO
	{
		public int? Id { get; set; }

		[Required]
		//[Range(1, 50)]
		public string CallLetters { get; set; }

		[Required]
		//[Range(1, 50)]
		public string Owner { get; set; }

		[Required]
		//[Range(1, 50)]
		public string Format { get; set; }

		public int[]? AffiliateIds { get; set; }
		public int[]? BroadcastTypeIds { get; set; }
		public int[]? MarketIds { get; set; }
	}
}
