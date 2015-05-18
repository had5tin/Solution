using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class ThemesStoreMap : EntityTypeConfiguration<ThemesStore>
    {
        public ThemesStoreMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.SeoUrl)
                .HasMaxLength(255);

            this.Property(t => t.Image)
                .HasMaxLength(255);

            this.Property(t => t.ImagePhone)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ThemesStore");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SeoUrl).HasColumnName("SeoUrl");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.ImagePhone).HasColumnName("ImagePhone");
            this.Property(t => t.Demo).HasColumnName("Demo");
            this.Property(t => t.Setting).HasColumnName("Setting");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        }
    }
}
