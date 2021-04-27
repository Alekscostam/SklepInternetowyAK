using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SklepInternetowyAK.Models;

namespace SklepInternetowyAK.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}