using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class SystemSettingMap : EntityTypeConfiguration<SystemSetting>
    {
        public SystemSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.setting_key)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.Options)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SystemSettings");
            this.Property(t => t.setting_key).HasColumnName("setting_key");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Options).HasColumnName("Options");
            this.Property(t => t.IsRequired).HasColumnName("IsRequired");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
