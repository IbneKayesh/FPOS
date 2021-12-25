using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace FPOS.AppModels
{
    public class fposDbContext:DbContext
    {
        public fposDbContext() : base("name=fposConStr")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            modelBuilder.Entity<PRODUCT_BRANDS>()
                        .HasIndex(c => c.BRAND_NAME)
                        .IsUnique()
                        .HasName("UK_BRAND_NAME");
        }


        
        public virtual DbSet<PRODUCT_BRANDS> PRODUCT_BRANDS { get; set; }
    }
}
