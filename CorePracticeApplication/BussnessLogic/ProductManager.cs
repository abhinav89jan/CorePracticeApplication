using CorePracticeApplication.DataBase;
using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Filter;
using CorePracticeApplication.Model;
using CorePracticeApplication.Sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePracticeApplication.BussnessLogic
{
    public class ProductManager : IProductManager
    {
        public AdventureEntitiesContext _adventureEntitiesContext;

        public ProductManager(AdventureEntitiesContext adventureEntitiesContext)
        {
            _adventureEntitiesContext = adventureEntitiesContext;
        }

        public List<Product> GetProduct()
        {
            var result = _adventureEntitiesContext.Products?.ToList();
            return result;
        }

        public List<Product> GetProductByFilter(ProductFilterApiModel productFilterApiModel)
        {
            var result = _adventureEntitiesContext
                .Products?
                .WhereProduct(productFilterApiModel)?
                .ToSortProduct(productFilterApiModel)
                .ToList();

            return result;
        }

        public Product GetProductById(int Id)
        {
            var result = _adventureEntitiesContext.Products?.Where(x => x.ProductID == Id)?.FirstOrDefault();
            return result;
        }
    }
}
