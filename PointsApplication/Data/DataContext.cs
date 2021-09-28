using Microsoft.EntityFrameworkCore;
using PointsApplication.Entities;

namespace PointsApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CustomPoint> Points { get; set; }
        public DbSet<PointList> PointLists{ get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PointList>()
                .HasMany(pl => pl.Points)
                .WithOne()
                .HasForeignKey(p => p.PointListId);
        }
    }

}
