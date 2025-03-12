using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class ReleasePermission
    {
        public int ReleasePermissionId { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int warehouseId { get; set; }
        public virtual Warehouse warehouse { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer customer { get; set; }


        public virtual ICollection<ReleasePermProducts> releasePermProducts { get; set; }
    }
}
