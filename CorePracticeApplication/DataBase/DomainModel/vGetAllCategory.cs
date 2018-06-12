using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorePracticeApplication.DataBase.DomainModel
{
    public class vGetAllCategory
    {
        [Key]
        public string ParentProductCategoryName { get; set; }
        public string ProductCategoryName { get; set; }
        public Nullable<int> ProductCategoryID { get; set; }
    }
}
