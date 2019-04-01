using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lesson.Models
{
    public class ProductKindContext:DbContext
    {
        public ProductKindContext(DbContextOptions<ProductKindContext> options)
            :base(options)
        {

        }
        public DbSet<ProductKindItem> ProductKindItems { get; set; }
    }
}
