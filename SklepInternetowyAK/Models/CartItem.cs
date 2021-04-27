using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowyAK.Models
{
    public class CartItem
    {
        public Film Film { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }  

    }
}