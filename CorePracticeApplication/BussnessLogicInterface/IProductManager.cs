using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Model;
using System.Collections.Generic;

namespace CorePracticeApplication
{
    public interface IProductManager
    {
        List<Product> GetProduct();

        Product GetProductById(int Id);

        List<Product> GetProductByFilter(ProductFilterApiModel productFilterApiModel);
    }
}
