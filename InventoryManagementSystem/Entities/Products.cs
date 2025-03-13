using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class Products
    {
        public int ProductsId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public double Price { get; set; }

        //navigation property
        public virtual ICollection<SupplyPermProducts> supplyPermProducts { get; set; }
        public virtual ICollection<ReleasePermProducts> releasePermProducts { get; set; }
        public virtual ICollection<TransferProductsBySuppliers> transferPermProducts { get; set; }
        public virtual ICollection<WhProductsBySupplier> WhProducts { get; set; }

        // Many-to-Many Relationship
        public virtual ICollection<ProductMeasuringUnit> ProductMeasuringUnits { get; set; }


        public int CategoryId { get; set; }  // FK
        public Category category { get; set; }

    }
}
