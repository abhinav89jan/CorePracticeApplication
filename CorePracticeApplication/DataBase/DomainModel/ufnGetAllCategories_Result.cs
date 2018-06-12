using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePracticeApplication.DataBase.DomainModel
{
    public class ufnGetAllCategories_Result
    {
        public string ParentProductCategoryName { get; set; }
        public string ProductCategoryName { get; set; }
        public int ProductCategoryID { get; set; }
    }
}
