using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : Controller
    {
        IList<ProductDetail> product_details = new List<ProductDetail>();

        public ProductDetailController()
        {
            product_details.Add(new ProductDetail { ProductId = 1, Name = "Galaxy S8", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 2, Name = "Galaxy S6", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 3, Name = "Galaxy Note 5", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 4, Name = "Galaxy Note 4", Description = "SmartPhone", Quanlity = "Good" });

            product_details.Add(new ProductDetail { ProductId = 5, Name = "Xperia XZ4", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 6, Name = "Xperia X2A", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 7, Name = "Xperia XA Dual", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 8, Name = "Xperia XA2 Plus", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 9, Name = "Xperia XA1", Description = "SmartPhone", Quanlity = "Good" });

            product_details.Add(new ProductDetail { ProductId = 10, Name = "10 EVO", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 11, Name = "U11", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 12, Name = "Desire 820G", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 13, Name = "Desire 628G", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 14, Name = "Desire 700", Description = "SmartPhone", Quanlity = "Good" });

            product_details.Add(new ProductDetail { ProductId = 15, Name = "IPhone 6", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 16, Name = "IPhone 7", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 17, Name = "IPhone 7 Plus", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 18, Name = "IPhone 8 Plus", Description = "SmartPhone", Quanlity = "Good" });

            product_details.Add(new ProductDetail { ProductId = 19, Name = "Vivo V11", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 20, Name = "Vivo V9", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 21, Name = "Vivo Y91", Description = "SmartPhone", Quanlity = "Good" });
            product_details.Add(new ProductDetail { ProductId = 22, Name = "Vivo Y71", Description = "SmartPhone", Quanlity = "Good" });
        }

        //GET: api/ProductDetail/GetProductDetail/Id
        //api/ProductDetail/GetProductDetail?id=3

        [HttpGet]
        [Route("GetProductDetail")]
        public async Task<object> GetProductDetail(long id)
        {
            var result = this.product_details.Where(p => p.ProductId == id).FirstOrDefault();
            return await Task.FromResult(result);
        }
    }
}
