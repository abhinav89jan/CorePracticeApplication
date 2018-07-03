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
                        return filter.SortDirection == "ASC" ? product.OrderBy(x => x.ProductID)
                            : product.OrderByDescending(x => x.ProductID);

                    case "name":
                        return filter.SortDirection == "ASC" ? product.OrderBy(x => x.Name)
                            : product.OrderByDescending(x => x.Name);

                    case "cost":
                        return filter.SortDirection == "ASC" ? product.OrderBy(x => x.StandardCost)
                            : product.OrderByDescending(x => x.StandardCost);

                    default:
                        return product.OrderBy(x => x.ProductID);
                }
            }
        }
    }
}