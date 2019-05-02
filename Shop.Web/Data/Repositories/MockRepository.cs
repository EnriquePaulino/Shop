namespace Shop.Web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Shop.Web.Data.Entities;

    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var proctocts = new List<Product>();
            proctocts.Add(new Product { Id = 1, Name = "One", Price = 10 });
            proctocts.Add(new Product { Id = 2, Name = "Two", Price = 20 });
            proctocts.Add(new Product { Id = 3, Name = "Three", Price = 30 });
            proctocts.Add(new Product { Id = 4, Name = "Four", Price = 40 });
            proctocts.Add(new Product { Id = 5, Name = "Five", Price = 50 });

            return proctocts;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
