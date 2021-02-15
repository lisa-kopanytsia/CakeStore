using System;
using System.Collections.Generic;
using System.Linq;
using CakeShop1.Models;
using CakeShop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetAllProduct.OrderBy(c => c.ProductId);
                currentCategory = "Все товары";
            }
            else
            {
                products = _productRepository.GetAllProduct.Where(c => c.Category.CategoryName == category);
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
           
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
