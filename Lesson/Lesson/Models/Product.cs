using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.Models
{
    public class Product
    {
        public long Id { get; set; }
        public long ProductKindId { get; set; }
        public string NameProduct { get; set; }
    }
}
