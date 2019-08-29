using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using product.Models;

namespace product.IRepositotry
{
    public interface IReposite
    {
        void insertproduct(Product pro);

        List<Product> GetProducts();
    }
}