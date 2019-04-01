using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.Models
{
    public static class ProductDB
    {
        public static IList<Product> products = new List<Product>();

        static ProductDB()
        {
            InitData();
        }
        static void InitData()
        {
            products.Add(new Product { Id = 1, ProductKindId = 1, NameProduct = "Galaxy S8" });
            products.Add(new Product { Id = 2, ProductKindId = 1, NameProduct = "Galaxy S6" });
            products.Add(new Product { Id = 3, ProductKindId = 1, NameProduct = "Galaxy Note 5" });
            products.Add(new Product { Id = 4, ProductKindId = 1, NameProduct = "Galaxy Note 4" });

            products.Add(new Product { Id = 5, ProductKindId = 2, NameProduct = "Xperia XZ4" });
            products.Add(new Product { Id = 6, ProductKindId = 2, NameProduct = "Xperia X2a" });
            products.Add(new Product { Id = 7, ProductKindId = 2, NameProduct = "Xperia XA Dual" });
            products.Add(new Product { Id = 8, ProductKindId = 2, NameProduct = "Xperia XA2 Plus" });
            products.Add(new Product { Id = 9, ProductKindId = 2, NameProduct = "Xperia XA1" });

            products.Add(new Product { Id = 10, ProductKindId = 3, NameProduct = "10 EVO" });
            products.Add(new Product { Id = 11, ProductKindId = 3, NameProduct = "U11" });
            products.Add(new Product { Id = 12, ProductKindId = 3, NameProduct = "Desire 820G" });
            products.Add(new Product { Id = 13, ProductKindId = 3, NameProduct = "Desire 628G" });
            products.Add(new Product { Id = 14, ProductKindId = 3, NameProduct = "Desire 700" });

            products.Add(new Product { Id = 15, ProductKindId = 4, NameProduct = "IPhone 6" });
            products.Add(new Product { Id = 16, ProductKindId = 4, NameProduct = "IPhone 7" });
            products.Add(new Product { Id = 17, ProductKindId = 4, NameProduct = "IPhone 7 Plus" });
            products.Add(new Product { Id = 18, ProductKindId = 4, NameProduct = "IPhone 8 Plus" });

            products.Add(new Product { Id = 19, ProductKindId = 5, NameProduct = "Vivo V11" });
            products.Add(new Product { Id = 20, ProductKindId = 5, NameProduct = "Vivo V9" });
            products.Add(new Product { Id = 21, ProductKindId = 5, NameProduct = "Vivo Y91" });
            products.Add(new Product { Id = 22, ProductKindId = 5, NameProduct = "Vivo Y71" });
        }
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }
        
        public static void DeleteProduct(Product product)
        {
            products.Remove(product);
        }
    }
}
