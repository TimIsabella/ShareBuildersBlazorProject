using System.ComponentModel.DataAnnotations.Schema;

namespace ShareBuildersProject_DataAccess.Composite
{
	public class AffiliateComposite
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int StationId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int AffiliateId { get; set; }
	}
}