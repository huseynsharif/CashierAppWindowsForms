using CashierApp3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp3.business
{
    internal class ProductManager
    {
        private readonly MyDbContext dbContext;

        public ProductManager(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public Product? GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }
    }
}
