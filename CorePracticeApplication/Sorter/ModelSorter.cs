using CorePracticeApplication.DataBase.DomainModel;
using CorePracticeApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePracticeApplication.Sorter
{
    public static class ModelSorter
    {
        public static IEnumerable<Product> ToSortProduct(this IEnumerable<Product> product, ProductFilterApiModel filter)
        {
            if (product == null)
            {
                return product;
            }
            else
            {
                switch (filter.SortBy)
                {
                    case "Id":
                        if (filter.SortDirection == "ASC")
                            return product.OrderBy(x => x.ProductID);
                        else
                            return product.OrderByDescending(x => x.ProductID);

                    default:
                        return product.OrderBy(x => x.ProductID);
                }
            }
        }
    }
}
