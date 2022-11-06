using Microsoft.EntityFrameworkCore;
using ShareBuildersProject_DataAccess.Composite;
using ShareBuildersProject_DataAccess.Data.ModelData;
using ShareBuildersProject_DataAccess.ModelData.CompositeData;
using ShareBuildersProject_DataAccess.Models;

namespace ShareBuildersProject_DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{ }

		public DbSet<Affiliate> Affiliates { get; set; }
		public DbSet<BroadcastType> BroadcastTypes { get; set; }
		public DbSet<Market> Markets { get; set; }
		public DbSet<Station> Stations { get; set; }
		public DbSet<User> Users { get; set; }

		//Composites
		public DbSet<AffiliateComposite> AffiliateComposites { get; set; }
		public DbSet<BroadcastTypeComposite> BroadcastTypeComposites { get; set; }
		public DbSet<MarketComposite> MarketComposites { get; set; }
		public DbSet<UserComposite> UserComposites { get; set; }

		//Populate with preset data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Affiliate>().HasData(AffiliateData.Data);
			modelBuilder.Entity<BroadcastType>().HasData(BroadcastTypeData.Data);
			modelBuilder.Entity<Market>().HasData(MarketData.Data);
			modelBuilder.Entity<Station>().HasData(StationData.Data);
			modelBuilder.Entity<User>().HasData(UserData.Data);

			//Composites
			modelBuilder.Entity<AffiliateComposite>().HasKey(composite => new { composite.StationId, composite.AffiliateId});
			modelBuilder.Entity<AffiliateComposite>().HasData(AffiliateCompositeData.Data);

			modelBuilder.Entity<BroadcastTypeComposite>().HasKey(composite => new { composite.StationId, composite.BroadcastTypeId });
			modelBuilder.Entity<BroadcastTypeComposite>().HasData(BroadcastTypeCompositeData.Data);

			modelBuilder.Entity<MarketComposite>().HasKey(composite => new { composite.StationId, composite.MarketId });
			modelBuilder.Entity<MarketComposite>().HasData(MarketCompositeData.Data);

			modelBuilder.Entity<UserComposite>().HasKey(composite => new { composite.UserId, composite.StationId });
			modelBuilder.Entity<UserComposite>().HasData(UserCompositeData.Data);
		}
	}
}
