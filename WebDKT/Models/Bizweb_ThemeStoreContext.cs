using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebDKT.Models.Mapping;

namespace WebDKT.Models
{
    public partial class Bizweb_ThemeStoreContext : DbContext
    {
        static Bizweb_ThemeStoreContext()
        {
            Database.SetInitializer<Bizweb_ThemeStoreContext>(null);
        }

        public Bizweb_ThemeStoreContext()
            : base("Name=Bizweb_ThemeStoreContext")
        {
        }

        public DbSet<Collection> Collections { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<ThemeColletion> ThemeColletions { get; set; }
        public DbSet<ThemeFeature> ThemeFeatures { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<ThemesStore> ThemesStores { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CollectionMap());
            modelBuilder.Configurations.Add(new FeatureMap());
            modelBuilder.Configurations.Add(new PageMap());
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new ResourceMap());
            modelBuilder.Configurations.Add(new ReviewMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new SystemSettingMap());
            modelBuilder.Configurations.Add(new ThemeColletionMap());
            modelBuilder.Configurations.Add(new ThemeFeatureMap());
            modelBuilder.Configurations.Add(new ThemeMap());
            modelBuilder.Configurations.Add(new ThemesStoreMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
