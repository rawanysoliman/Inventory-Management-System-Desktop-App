using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class SupplyPermProducts
    {
        public int SupplyPermProductsId { get; set; }
        public int SupplyPermissionId { get; set; }
        public SupplyPermission supplyPermission { get; set; }
        public int ProductId { get; set; }
        public Products product { get; set; }
        public int Quantity { get; set; }
        public int ExpiryDuration { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime supplyDate { get; set; }


        //[NotMapped]
        //public bool IsExpired => ExpireDate < DateTime.Now;


        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int RemainingDays { get; set; }

    }
}
