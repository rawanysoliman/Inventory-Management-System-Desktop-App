using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Entities
{
    public class TransferPermission
    {
        [Key]
        public int TransferId { get; set; }
        public DateTime TransferDate { get; set; }

        //foreign keys adjusted with fluent api
        public int sourceWarehouseId { get; set; }
        public Warehouse sourceWarehouse { get; set; }

        public int destWarehouseId { get; set; }
        public Warehouse destWarehouse { get; set; }


        public virtual ICollection<TransferProductsBySuppliers> transferedItemDetails { get; set; }


    }
}
