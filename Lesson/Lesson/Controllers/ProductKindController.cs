using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lesson.Models;
using System.Collections.Concurrent;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductKindController : ControllerBase
    {
       
        private readonly ProductKindContext _context;

        public ProductKindController(ProductKindContext context)
        {
            _context = context;
            if(_context.ProductKindItems.Count() ==0)
            {
                _context.ProductKindItems.Add(new ProductKindItem { NameProductKind = "Samsung" });
                _context.ProductKindItems.Add(new ProductKindItem { NameProductKind = "Sony" });
                _context.ProductKindItems.Add(new ProductKindItem { NameProductKind = "HTC" });
                _context.ProductKindItems.Add(new ProductKindItem { NameProductKind = "Apple" });
                _context.ProductKindItems.Add(new ProductKindItem { NameProductKind = "Vivo" });
                _context.SaveChanges();
            }
        }

        //Get : api/ProductKind/GetProductKinds

        [HttpGet]
        [Route("GetProductKinds")]
        public async Task<ActionResult<IEnumerable<ProductKindItem>>> GetProductKinds()
        {
            return await _context.ProductKindItems.ToListAsync();
        }

    }
}
