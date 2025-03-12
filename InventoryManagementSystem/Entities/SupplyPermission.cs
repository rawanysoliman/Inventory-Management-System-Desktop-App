using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class SupplyPermission
    {
        [Key]
        public int SupplyId { get; set; }

        [Required]
        public DateTime supplyDate { get; set; }
        public virtual ICollection<SupplyPermProducts> supplyPermProducts { get; set; }

        //fk1
        public int WarehouseId { get; set; }
        public Warehouse warehouse { get; set; }

        //fk2
        public int supplierId { get; set; }
        public Supplier supplier { get; set; }

    }
}
