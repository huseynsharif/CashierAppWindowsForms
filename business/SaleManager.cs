using CashierApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace CashierApp3.business
{
    internal class SaleManager
    {
        private readonly MyDbContext dbContext;

        public SaleManager(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Models.Sale? GetById(int id)
        {
            return dbContext.Sales.FirstOrDefault(s => s.Id == id);
        }

        public List<Models.Sale> GetAll()
        {
            return dbContext.Sales.Include(s => s.Product).ToList();
        }

        public bool SaleProduct(Models.Sale sale)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.Id == sale.ProductId);
            if (product == null)
            {
                return false;
            }

            if (product.Count >= sale.Count)
            {
                product.Count -= sale.Count;

                sale.Product = product;
                dbContext.Sales.Add(sale);
                dbContext.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
