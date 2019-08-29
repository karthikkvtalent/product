using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using product.IRepositotry;
using product.Repository;
using product.Models;

namespace product.Business_Access_Layer
{
    public class BAL
    {
        IReposite Iobj;

        public BAL(Reposite reposite)
        {
            Iobj = reposite;
        }

        public void insertproduct(Product pro)
        {
            Iobj.insertproduct(pro);
        }
         public List<Product> GetProducts()
        {
            return Iobj.GetProducts();
        }
    }
}