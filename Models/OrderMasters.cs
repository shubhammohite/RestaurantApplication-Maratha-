using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maratha_Restaurant_Application.Models
{
    public class OrderMasters
    {
        [Key]
        public long OrderMasterId { get; set; }
         
        [Column(TypeName = "nvarchar(100)")]
        public string OrderNumber { get; set; }

        public int CustomerId {  get; set; }
        public Customers  Customers { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string PMethod { get; set; }

        public int GTotal { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

    }
}
