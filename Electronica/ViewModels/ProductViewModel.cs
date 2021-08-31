using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Models;

namespace Electronica.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
       

        [Display(Name = "Product Type")]
        public int SelectedProductType { get; set; }
        public IEnumerable<SelectListItem> dllProductType { get; set; }


        [Display(Name = "Product Category")]
        public int SelectedProductCategory { get; set; }
        public IEnumerable<SelectListItem> dllProductCategory { get; set; }


        public int Discount { get; set; }

        [Display(Name = "Unit Price")]
        public double UnitPrice { get; set; }

         [Display(Name = "Quantity in Stock")]
        public int QuantityInStock { get; set; }

         [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }

        [Display(Name = "Is Featured")]
        public bool IsFeatured { get; set; }
    }
}