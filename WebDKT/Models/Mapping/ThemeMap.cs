using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class ThemeMap : EntityTypeConfiguration<Theme>
    {
        public ThemeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ThemeType)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ThemeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Themes");
            this.Property(t => t.ThemeType).HasColumnName("ThemeType");
            this.Property(t => t.ThemeName).HasColumnName("ThemeName");
            this.Property(t => t.StoreTheme).HasColumnName("StoreTheme");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
