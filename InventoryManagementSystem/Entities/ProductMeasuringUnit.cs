using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entities
{
    public class ProductMeasuringUnit
    {
        public int ProductId { get; set; }  // FK to Product
        public int UnitId { get; set; }  // FK to MeasuringUnit

        public Products Product { get; set; }
        public MeasuringUnit MeasuringUnit { get; set; }
    }
}
