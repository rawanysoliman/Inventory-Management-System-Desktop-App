using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class WhProductsBySupplier
    {
        [Key]
        public int Id { get; set; }


        public int WarehouseId { get; set; }
        public virtual Warehouse warehouse { get; set; }

        public int ProductId { get; set; }
        public virtual Products product { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier supplier { get; set; }

        public int CurrentStock { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime supplyDate { get; set; }


        [NotMapped]
        public bool IsExpired => ExpireDate < DateTime.Now;

    }
}
