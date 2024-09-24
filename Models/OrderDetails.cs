using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maratha_Restaurant_Application.Models
{
    public class OrderDetails
    { 
        [Key]
        public long OrderDetailId { get; set; }

        public long OrderMasterId { get; set; }
        public OrderMasters OrderMasters { get; set; }
        public int FoodItemId {  get; set; }
        public FoodItems FoodItems { get; set; }
        public int FoodItemPrice{ get; set; }

        public int Quantity { get; set; }

    }
}
