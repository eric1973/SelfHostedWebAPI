using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

using WebAPIConsoleUIHost.Model;
using WebAPIConsoleUIHost.Model.Interface;
using WebAPIConsoleUIHost.Store;
using WebAPIConsoleUIHost.Store.Interface;

namespace WebAPIConsoleUIHost.Controller.Base
{
    public abstract class AbstractDomainController<TEntity> : ApiController where TEntity:IEntity
    {
        private readonly IPersistence persistencelayer;
        private static readonly IDictionary<Type, Func<IPersistence>> factory;

        public IPersistence Store
        {
            get
            {
                return persistencelayer;
            }
        }
        static AbstractDomainController()
        {
            factory = new Dictionary<Type, Func<IPersistence>>
            {
                { typeof(Product), () => new ProductPersistenceLayer() }
            };
        }
        public AbstractDomainController()
        {
            // Get PersistenceLayer from Factory
            this.persistencelayer = factory[typeof(TEntity)]();

        }
    }
}
