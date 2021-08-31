using Electronica.Areas.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronica.Helpers
{
    public class Utility
    {
        public static IEnumerable<SelectListItem> GetProducts(IDataService DataContext)
        {
            var types = DataContext.GetAllProducts().Select(x => new SelectListItem
            {
                Value = x.ProductId.ToString(),
                Text = x.ProductName
            });
            return new SelectList(types, "Value", "Text");
        }
        public static IEnumerable<SelectListItem> GetProductsCategories(IDataService DataContext)
        {
            var types = DataContext.GetAllProductCategories().Select(x => new SelectListItem
                {
                    Value = x.CategoryId.ToString(),
                    Text = x.CategoryName
                });
            return new SelectList(types, "Value", "Text");
        }

        public static IEnumerable<SelectListItem> GetProductsTypes(IDataService DataContext)
        {
            var types = DataContext.GetAllProductTypes().Select(x => new SelectListItem
                {
                    Value = x.ProductTypeId.ToString(),
                    Text = x.Type
                });
            return new SelectList(types, "Value", "Text");
        }
    }
    }
