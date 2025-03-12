using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.configuration
{
    public class transferPerConfig : IEntityTypeConfiguration<TransferPermission>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TransferPermission> builder)
        {
            builder.HasKey(t => t.TransferId);
            builder.Property(t => t.TransferDate).IsRequired();
            builder.HasOne(t => t.sourceWarehouse)
                .WithMany(w => w.transferSource)
                .HasForeignKey(t => t.sourceWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(t => t.destWarehouse)
                .WithMany(w => w.transferDestination)
                .HasForeignKey(t => t.destWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
