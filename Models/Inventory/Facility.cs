using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models.Inventory
{
    public class Facility
    {
        [Key]
        public int FacilityId { get; set; }
        [Required]
        public string FacilityName { get; set; }

        public string Landmark { get; set; }
        [Required]
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [MaxLength(6)]
        [RegularExpression("([1-9][0-9]*)")]
        public string ZipCode { get; set; }



       // public List<Resource> Resource { get; set; }
       public virtual ICollection<Resource> Resources { get; set; }
    }
}
