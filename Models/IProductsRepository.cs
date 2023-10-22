using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Models
{
    internal interface IProductsRepository
    {
        void Add(ProductsModel productsModel);
        void Edit(ProductsModel productsModel);
        void Delete(int id);
        IEnumerable<ProductsModel> GetAll();
        IEnumerable<ProductsModel> GetByValue(string value);
    }
}
