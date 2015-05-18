using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebNN.Models.Mapping
{
    public class ItemOrderMap : EntityTypeConfiguration<ItemOrder>
    {
        public ItemOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemId, t.OrderId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ItemOrders");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");

            //// Relationships
            //this.HasRequired(t => t.Item)
            //    .WithMany(t => t.ItemOrders)
            //    .HasForeignKey(d => d.ItemId);
            //this.HasRequired(t => t.Order)
            //    .WithMany(t => t.ItemOrders)
            //    .HasForeignKey(d => d.OrderId);

        }
    }
}
