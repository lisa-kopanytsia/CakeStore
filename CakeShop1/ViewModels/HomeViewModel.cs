using CakeShop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOnSale { get; set; }
    }
}
