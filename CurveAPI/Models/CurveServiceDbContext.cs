using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;

namespace etrmpro.CurveAPI.Models
{
    public class CurveServiceDbContext : IdentityDbContext<AuthUser>
    {
        public CurveServiceDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static CurveServiceDbContext Create()
        {
            return new CurveServiceDbContext();
        }

        public DbSet<AssetClass> AssetClasses { get; set; }
        public DbSet<AssetSubClass> AssetSubClasses { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Curve> Curves { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<AuthUser>().ToTable("AuthUsers");
            modelBuilder.Entity<IdentityUserRole>().ToTable("AuthUserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("AuthUserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("AuthUserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("AuthRoles");
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);
                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }

    public class ApplicationDbContextInitializer : DropCreateDatabaseAlways<CurveServiceDbContext>
    {
        protected override void Seed(CurveServiceDbContext context)
        {
            context.Tenants.AddOrUpdate(t => t.TenantId,
                new Tenant() { TenantId = 1, Name = "Tenant1" }
            );

            context.AssetClasses.AddOrUpdate(a => a.AssetClassId,
                new AssetClass() { AssetClassId = 1, Name = "Commodity" }
                );

            context.AssetSubClasses.AddOrUpdate(a => a.AssetSubClassId,
                new AssetSubClass() { AssetSubClassId = 1, AssetClassId = 1, Name = "Energy" }
                );

            context.Commodities.AddOrUpdate(c => c.CommodityId,
               new Commodity() { CommodityId = 1, AssetSubClassId = 1, Name = "Electricity" },
               new Commodity() { CommodityId = 2, AssetSubClassId = 1, Name = "Natural Gas" }
            );

            base.Seed(context);
        }
    }
}