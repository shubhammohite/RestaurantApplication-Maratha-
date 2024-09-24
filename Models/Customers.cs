using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maratha_Restaurant_Application.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string CustomerName { get; set; }
    }
}
