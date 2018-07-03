using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Model;
using System.Linq;

namespace CorePracticeApplication.Filter
{
    public static class ModelFilter
    {
        public static IQueryable<Product> WhereProduct(this IQueryable<Product> product, ProductFilterApiModel filterModel)
        {
            return product.Where(x => (x.ProductID == filterModel.Id && x.Name.Contains(filterModel.Name)) || x.ProductID == filterModel.Id || x.Name.Contains(filterModel.Name));
        }
    }
}