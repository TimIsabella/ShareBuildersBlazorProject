using System.ComponentModel.DataAnnotations.Schema;

namespace ShareBuildersProject_DataAccess.Composite
{
	public class BroadcastTypeComposite
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int StationId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int BroadcastTypeId { get; set; }
	}
}