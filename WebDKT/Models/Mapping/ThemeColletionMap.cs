using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class ThemeColletionMap : EntityTypeConfiguration<ThemeColletion>
    {
        public ThemeColletionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ThemeId, t.CollectionId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ThemeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CollectionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ThemeColletions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ThemeId).HasColumnName("ThemeId");
            this.Property(t => t.CollectionId).HasColumnName("CollectionId");

            // Relationships
            this.HasRequired(t => t.Collection)
                .WithMany(t => t.ThemeColletions)
                .HasForeignKey(d => d.CollectionId);
            this.HasRequired(t => t.ThemesStore)
                .WithMany(t => t.ThemeColletions)
                .HasForeignKey(d => d.ThemeId);

        }
    }
}
