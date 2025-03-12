using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class TransferProductsBySuppliers
    {
        [Key]
        public int Id { get; set; }


        public int productID { get; set; }
        public Products product { get; set; }


        public int supplierId { get; set; }
        public Supplier supplier { get; set; }

        public int transferPermissionId { get; set; }
        public TransferPermission transferPermission { get; set; }



        public int Quantity { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ProductionDate { get; set; }


        [NotMapped]
        public bool IsExpired => ExpireDate < DateTime.Now;


        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int RemainingDays { get; set; }
    }
}
