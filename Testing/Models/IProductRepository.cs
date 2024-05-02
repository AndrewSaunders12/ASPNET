using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
