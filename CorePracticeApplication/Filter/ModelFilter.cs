using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Model;
using System.Linq;

namespace CorePracticeApplication.Filter
{
    public static class ModelFilter
    {
        public static IQueryable<Product> WhereProduct(this IQueryable<Product> product, ProductFilterApiModel filterModel)
        {
            return product.Where(x => x.Name == filterModel.Name)
                .Where(x => x.ProductNumber == filterModel.ProductNumber)
                .Where(x => x.StandardCost == filterModel.Cost)
                .Where(x => x.Color == filterModel.Color);
        }
    }
}
