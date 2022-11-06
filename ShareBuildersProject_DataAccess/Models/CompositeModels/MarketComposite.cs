using System.ComponentModel.DataAnnotations.Schema;

namespace ShareBuildersProject_DataAccess.Composite
{
	public class MarketComposite
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int StationId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int MarketId { get; set; }
	}
}