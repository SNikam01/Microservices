using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var o1 = new Product("P01","Product One", 100);
            var o2 = new Product("P02", "Product Two", 200);
            return Ok(new List<Product> { o1, o2 });
        }

        public class Product
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public decimal Amount { get; set; }

            public Product(string id,string name, decimal amount)
            {
                Id = id;
                Name = name;
                Amount = amount;
            }
        }
    }

    
}
