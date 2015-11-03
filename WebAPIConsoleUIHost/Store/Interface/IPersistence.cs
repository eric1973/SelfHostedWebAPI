using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIConsoleUIHost.Model.Interface;

namespace WebAPIConsoleUIHost.Store.Interface
{
    public interface IPersistence
    {
        IEnumerable<IEntity> GetData();

        void AddData(IEntity enity);
    }
}
