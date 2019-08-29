using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using product.IRepositotry;
using product.Models;

namespace product.Repository
{
    public class Reposite : IReposite
    {
        public List<Product> GetProducts()
        {
            using (mvcEntities db = new mvcEntities())
            {
                return db.Products.ToList();
            }
        }

        public void insertproduct(Product pro)
        {
            using (mvcEntities db = new mvcEntities())
            {
                db.Products.Add(pro);
                db.SaveChanges();
            }
        }
    }
}