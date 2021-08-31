using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;
using Electronica.Helpers;
using Electronica.Models;
using Electronica.ViewModels;
using System.IO;

namespace Electronica.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private IDataService DataContext;

        public ProductsController() : this(MainContainer.DataService())
        {
            
        }

        public ProductsController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }

        //
        // GET: /Admin/Products/
        public ActionResult Index()
        {
            return View(DataContext.GetAllProducts());
        }

        [HttpGet]

        public ActionResult Create()
        {
            var model = new ProductViewModel()
            {
                dllProductCategory = Utility.GetProductsCategories(DataContext),
                dllProductType = Utility.GetProductsTypes(DataContext)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel, HttpPostedFileBase productPicture)
        {
            if (ModelState.IsValid)
            {
                 if (productPicture != null && productPicture.ContentLength > 0)
                 {
                   string path = Path.Combine(Server.MapPath("~/Media/products"),Path.GetFileName(productPicture.FileName));
                        productViewModel.ProductImage = path;
                        
                           
                 }

                var productModel = new Product()
                {
                    ProductName = productViewModel.ProductName,
                    CategoryId = productViewModel.SelectedProductCategory,
                    ProductTypeId = productViewModel.SelectedProductType,
                    Discount = productViewModel.Discount,
                    UnitPrice = productViewModel.UnitPrice,
                    QuantityInStock = productViewModel.QuantityInStock,
                    ProductDescription = productViewModel.ProductDescription,
                    ProductImage = productViewModel.ProductImage,
                    IsFeatured = productViewModel.IsFeatured
                };
                DataContext.AddProduct(productModel);
                return RedirectToAction("Index");
            }
            return View(productViewModel);
        }

        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = DataContext.FindProductById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(new ProductViewModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                dllProductCategory = Utility.GetProductsCategories(DataContext),
                SelectedProductCategory = product.CategoryId,
                dllProductType = Utility.GetProductsTypes(DataContext),
                SelectedProductType = product.ProductTypeId,
                Discount = product.Discount,
                UnitPrice = product.Discount,
                QuantityInStock = product.QuantityInStock,
                ProductDescription = product.ProductDescription,
                ProductImage = product.ProductImage,
                IsFeatured = product.IsFeatured
            });
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productModel = new Product()
                {
                    ProductName = product.ProductName,
                    ProductCategoryId = product.SelectedProductCategory,
                    ProductTypeId = product.SelectedProductType,
                    Discount = product.Discount,
                    UnitPrice = product.UnitPrice,
                    QuantityInStock = product.QuantityInStock,
                    ProductDescription = product.ProductDescription,
                    ProductImage = product.ProductImage,
                    IsFeatured = product.IsFeatured
                };
                DataContext.UpdateProduct(productModel);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = DataContext.FindProductById(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataContext.DeleteProduct(id);
            return RedirectToAction("Index");
        }

	}
}