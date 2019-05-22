using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace product_ms.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet("getProduct")]
        public ActionResult<IEnumerable<string>> Get()
        {
            Product product = GetDummyData();
            return Ok(product);
        }


        private Product GetDummyData()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Alexa",
                Price = "$98"
            };
            return product;
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
        }

    }
}
