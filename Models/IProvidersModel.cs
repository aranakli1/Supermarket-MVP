using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Models
{
    internal interface IProvidersModel
    {
        void Add(ProvidersModel providersModel);
        void Edit(ProvidersModel providersModel);
        void Delete(int id);
        IEnumerable<ProvidersModel> GetAll();
        IEnumerable<ProvidersModel> GetByValue(string value);
    }
}
