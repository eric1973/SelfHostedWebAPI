using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPIConsoleUIHost.Controller.Base;
using WebAPIConsoleUIHost.Model;
using WebAPIConsoleUIHost.Model.Interface;

namespace WebAPIConsoleUIHost.Controller
{
    public class ProductsController : AbstractDomainController<Product>
    {
        public List<IEntity> Get()
        {
            // get all products
            return this.Store.GetData().ToList();
        }
    }
}
