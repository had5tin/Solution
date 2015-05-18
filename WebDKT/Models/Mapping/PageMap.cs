using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class PageMap : EntityTypeConfiguration<Page>
    {
        public PageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.MetaKeyword)
                .HasMaxLength(500);

            this.Property(t => t.MetaDescription)
                .HasMaxLength(500);

            this.Property(t => t.SeoUrl)
                .HasMaxLength(255);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Layout)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Pages");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.MetaKeyword).HasColumnName("MetaKeyword");
            this.Property(t => t.MetaDescription).HasColumnName("MetaDescription");
            this.Property(t => t.SeoUrl).HasColumnName("SeoUrl");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Layout).HasColumnName("Layout");
        }
    }
}
