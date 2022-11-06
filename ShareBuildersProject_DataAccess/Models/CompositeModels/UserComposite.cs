using System.ComponentModel.DataAnnotations.Schema;

namespace ShareBuildersProject_DataAccess.Composite
{
	public class UserComposite
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int UserId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int StationId { get; set; }
	}
}