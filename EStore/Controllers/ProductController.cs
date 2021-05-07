using EStore.Models;
using EStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            ICategoryRepository categoryRepository = new MockCategoryRepository();
            List<Category> categories = categoryRepository.GetAllCategory();
            ProductViewModel viewModel = new ProductViewModel
            {
                Categories = categories
            };
            return View(viewModel);
        }

        public ViewResult Details(int id)
        {
            Product product = productRepository.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Create([FromForm]ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Product model = viewModel.Product;
                Product product = productRepository.Create(model);
                return RedirectToAction(nameof(Details), new { id = product.Id });
            }

            return View();
        }
    }
}
