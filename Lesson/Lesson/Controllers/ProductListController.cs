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
    public class ProductListController : ControllerBase
    {

        //tao ra  1 mang product
        public IList<Product> products = new List<Product>()
        {
            //new Product { Id = 1, ProductKindId = 1, NameProduct = "Galaxy S8" },
            //new Product { Id = 2, ProductKindId = 1, NameProduct = "Galaxy S6" },
            //new Product { Id = 3, ProductKindId = 1, NameProduct = "Galaxy Note 5" },
            //new Product { Id = 4, ProductKindId = 1, NameProduct = "Galaxy Note 4" },

            //new Product { Id = 5, ProductKindId = 2, NameProduct = "Xperia XZ4" },
            //new Product { Id = 6, ProductKindId = 2, NameProduct = "Xperia X2a" },
            //new Product { Id = 7, ProductKindId = 2, NameProduct = "Xperia XA Dual" },
            //new Product { Id = 8, ProductKindId = 2, NameProduct = "Xperia XA2 Plus" },
            //new Product { Id = 9, ProductKindId = 2, NameProduct = "Xperia XA1" },

            //new Product { Id = 10, ProductKindId = 3, NameProduct = "10 EVO" },
            //new Product { Id = 11, ProductKindId = 3, NameProduct = "U11" },
            //new Product { Id = 12, ProductKindId = 3, NameProduct = "Desire 820G" },
            //new Product { Id = 13, ProductKindId = 3, NameProduct = "Desire 628G" },
            //new Product { Id = 14, ProductKindId = 3, NameProduct = "Desire 700" },

            //new Product { Id = 15, ProductKindId = 4, NameProduct = "IPhone 6" },
            //new Product { Id = 16, ProductKindId = 4, NameProduct = "IPhone 7" },
            //new Product { Id = 17, ProductKindId = 4, NameProduct = "IPhone 7 Plus" },
            //new Product { Id = 18, ProductKindId = 4, NameProduct = "IPhone 8 Plus" },

            //new Product { Id = 19, ProductKindId = 5, NameProduct = "Vivo V11" },
            //new Product { Id = 20, ProductKindId = 5, NameProduct = "Vivo V9" },
            //new Product { Id = 21, ProductKindId = 5, NameProduct = "Vivo Y91" },
            //new Product { Id = 22, ProductKindId = 5, NameProduct = "Vivo Y71" },
        };

        public ProductListController()
        {
            products = ProductDB.products;
        }
        //GET:api/ProductList/GetAll

        [HttpGet]
        [Route("GetAll")]
        public async Task<IList<Product>> GetAll()
        {
            return await Task.FromResult(products);
        }

        //GET: api/ProductList/GetProductList/Id
        [HttpGet]
        [Route("GetProductList")]
        public async Task<IList<Product>> GetProductList(long id)
        {
            var result = products.Where(p => p.ProductKindId == id).ToList();
            return await Task.FromResult(result);
        }

        //POST: api/ProductList/PostProduct
        
        [HttpPost]
        [Route("PostProduct")]
        public async Task<IList<Product>>PostProduct(Product product)
        {
            //products.Add(product);
            ProductDB.AddProduct(product);
            return await Task.FromResult(products);
            //CreatedAtAction(nameof(GetAll), products);
            //var result = products.Where(p => p.ProductKindId == product.ProductKindId).ToList();
            //return await Task.FromResult(result);
        }

        //PUT: api/ProductList/PutProduct

        [HttpPut]
        [Route("PutProduct")]
        public async Task<IList<Product>> PutProduct(int idProduct,Product product)
        {
            var result = products.Where(p => p.Id == idProduct).FirstOrDefault();
            if (result != null)
            {
                result.Id = product.Id;
                result.ProductKindId = product.ProductKindId;
                result.NameProduct = product.NameProduct;
            }
            else
            {
                return null; 
            }
            return await Task.FromResult(products);
            //var listProduct = products.Where(p => p.ProductKindId == product.ProductKindId).ToList();
            //return await Task.FromResult(listProduct);
        }

        //DELETE: api/ProductList/DeleteProduct
        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task<IList<Product>> DeleteProduct(Product product)
        {
            var result = products.Where(p => p.Id == product.Id).FirstOrDefault();
            if (result != null)
            {
                ProductDB.DeleteProduct(result);
            }
            else
            {
                return null;
            }
            var listProduct = products.Where(p => p.ProductKindId == product.ProductKindId).ToList();
            return await Task.FromResult(listProduct);
        }
    }

}

