using System;
using System.Collections.Generic;
using CakeShop1.Models;


namespace CakeShop1.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }

    }
}
