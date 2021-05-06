using EStore.Models;
using EStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult Index()
        {
            List<Product> products = productRepository.GetAllProduct();
            return View(products);
        }

        public ViewResult Details(int id)
        {
            ProductViewModel viewModel = new ProductViewModel
            {
                Product = productRepository.GetProduct(id)
            };
            viewModel.PageTitle = $"{viewModel.Product.Name} Details";

            return View(viewModel);
        }
    }
}
