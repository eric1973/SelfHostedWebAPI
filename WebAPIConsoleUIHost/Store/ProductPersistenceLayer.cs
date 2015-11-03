using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIConsoleUIHost.Model;
using WebAPIConsoleUIHost.Model.Interface;
using WebAPIConsoleUIHost.Store.Interface;

namespace WebAPIConsoleUIHost.Store
{
    public class ProductPersistenceLayer : IPersistence
    {
        private readonly List<Product> store;

        public ProductPersistenceLayer()
        {
            store = new List<Product>
            {
                new Product
                {
                    Id      = 1,
                    Name    = "Movie",
                    Price   = 10.99M
                }
            };
        }
        public void AddData(IEntity enity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetData()
        {
            return store;
        }
    }
}
