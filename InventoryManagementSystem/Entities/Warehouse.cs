using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Entities
{
    public class Warehouse
    {
        [Key]
        public int WarhouseId { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        public string WarehouseLocation { get; set; }
        public string WarehouseManager { get; set; }

        // Navigation property

        // 1:m relation by fluent api
        public virtual ICollection<TransferPermission> transferSource { get; set; }

        public virtual ICollection<TransferPermission> transferDestination { get; set; }



        public virtual ICollection<SupplyPermission> supplyPermission { get; set; }

        public virtual ICollection<ReleasePermission> releasePermission { get; set; }


        public virtual ICollection<WhProductsBySupplier> WhProducts { get; set; }

        public Warehouse()
        {

            transferSource = new HashSet<TransferPermission>();
            transferDestination = new HashSet<TransferPermission>();

            supplyPermission = new HashSet<SupplyPermission>();
            releasePermission = new HashSet<ReleasePermission>();

            WhProducts = new HashSet<WhProductsBySupplier>();
        }
    }
}
