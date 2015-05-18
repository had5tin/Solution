using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebDKT.Models.Mapping
{
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Privilege)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("Permissions");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.ResourceId).HasColumnName("ResourceId");
            this.Property(t => t.Privilege).HasColumnName("Privilege");
            this.Property(t => t.IsAllowed).HasColumnName("IsAllowed");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Modified).HasColumnName("Modified");

            // Relationships
            this.HasRequired(t => t.Resource)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.ResourceId);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.Permissions)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
