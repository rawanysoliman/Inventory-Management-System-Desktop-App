using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class MeasuringUnit
    {
        [Key] // Primary Key
        public int UnitId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UnitName { get; set; }

        // Many-to-Many Navigation Property
        public ICollection<ProductMeasuringUnit> ProductMeasuringUnits { get; set; }
    }
}
