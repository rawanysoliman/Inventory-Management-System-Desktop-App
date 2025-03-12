using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class ReleasePermProducts
    {
        public int releasePermProductsId { get; set; }
        public int releasePermissionId { get; set; }
        public virtual ReleasePermission releasePermission { get; set; }

        public int productId { get; set; }
        public virtual Products product { get; set; }
        public int quantity { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime productionDate { get; set; }
        public DateTime ReleaseDate { get; set; }


        [NotMapped]
        public bool IsExpired => ExpireDate < DateTime.Now;


        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int RemainingDays { get; set; }

    }
}
