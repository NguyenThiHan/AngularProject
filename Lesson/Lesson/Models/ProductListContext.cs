using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lesson.Models
{
    public class ProductListContext:DbContext
    {
        public ProductListContext(DbContextOptions<ProductListContext> options)
         : base(options)
        {

        }
        public DbSet<Product> ProductListItems { get; set; }
    }
}
