using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models.Inventory
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        [Required]
        public string ResourceName { get; set; }

        [RegularExpression("([1-9][0-9]*)")]
        [Required]
        public string Quantity { get; set; }

        public string Description { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int FacilityId { get; set; }

        public Facility Facility { get; set; }
    }
}