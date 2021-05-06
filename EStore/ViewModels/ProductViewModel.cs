using EStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.ViewModels
{
    public class ProductViewModel
    {
        public string PageTitle { get; set; }
        public Product Product { get; set; }
    }
}
