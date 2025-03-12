using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName {  get; set; }

        public virtual ICollection<ReleasePermission> releasePermissions { get; set; }
    }
}
