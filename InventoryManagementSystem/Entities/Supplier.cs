using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLocation { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string faxNumber { get; set; } = string.Empty;

        //1:m relation 
        public virtual ICollection<SupplyPermission> supplyPermissions { get; set; }

        
        public virtual ICollection<TransferProductsBySuppliers> transferedItemDetails { get; set; }
        public virtual ICollection<WhProductsBySupplier> productDetails { get; set; }


    }
}
