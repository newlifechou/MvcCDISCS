using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace MvcCDISCS.Models
{
    public class ProductCategoryPage
    {
        public productcategory pc { get; set; }
        public IPagedList<product> products { get; set; }
    }
}