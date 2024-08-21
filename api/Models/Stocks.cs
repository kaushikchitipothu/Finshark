using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stocks
    {
        public int ID { get; set; }
        public string Symbol { get; set; } = String.Empty;
        public string Company { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = String.Empty;
        public string  MarketCap { get; set; } = String.Empty;
        public List<Comments> Comments { get; set; } = new List<Comments>();

    }
}