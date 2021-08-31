using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Electronica.Models;

namespace Electronica.Areas.Admin.Services
{
    public class DataService:IDataService
    {
        private ApplicationDbContext db = null;

        public DataService()
        {
            db = new ApplicationDbContext();
        }
        public IList<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public Product FindProductById(int id)
        {
            return db.Products.Find(id);
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("Property is null or Empty");
            }
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            //var productModel = db.Products.First(e => e.ProductId == product.ProductId);
            //productModel.ProductId = product.ProductId;
            //productModel.ProductCategoryId = product.ProductCategoryId;
            //productModel.ProductTypeId = product.ProductTypeId;
            //productModel.Discount = product.Discount;
            //productModel.UnitPrice = product.UnitPrice;
            //productModel.QuantityInStock = product.QuantityInStock;
            //productModel.ProductDescription = product.ProductDescription;
            //productModel.ProductImage = product.ProductImage;
            //db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
           var productDelete = db.Products.FirstOrDefault(p => p.ProductId == id);
            db.Entry(productDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public IList<Payment> GetAllPayments()
        {
            return db.Payments.ToList();
        }

        public Payment FindPaymentById(int id)
        {
            return db.Payments.Find(id);
        }

        public void AddPayment(Payment payment)
        {
            db.Payments.Add(payment);
        }

        public void UpdatePayment(Payment payment)
        {
            db.Entry(payment).State = EntityState.Modified;
        }

        public void DeletePayment(int id)
        {
           var paymentDelete = db.Payments.FirstOrDefault(p => p.PaymentId == id);
            db.Entry(paymentDelete).State = EntityState.Deleted;
            db.SaveChanges();
          }

        public IList<Order> GetAllOrders()
        {
            return db.Orders.ToList();
        }

        public Order FindOrderById(int id)
        {
            return db.Orders.Find(id);
            
        }

        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            db.Entry(order).State = EntityState.Modified;
        }

        public void DeleteOrder(int id)
        {
            var orderDelete = db.Orders.FirstOrDefault(p => p.OrderNo == id);
            db.Entry(orderDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public IList<ProductCategory> GetAllProductCategories()
        {
            return db.ProductCategories.ToList();
        }

        public ProductCategory FindProductCategoryById(int id)
        {
            return db.ProductCategories.Find(id);
        }

        public void AddProductCategory(ProductCategory productCategory)
        {
            db.ProductCategories.Add(productCategory);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            db.Entry(productCategory).State = EntityState.Modified;
        }

        public void DeleteProductCategory(int id)
        {
            var productCategoryDelete = db.ProductCategories.FirstOrDefault(p => p.CategoryId == id);
            db.Entry(productCategoryDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public IList<ProductType> GetAllProductTypes()
        {
            return db.ProductTypes.ToList();
        }

        public ProductType FindProductTypeById(int id)
        {
            return db.ProductTypes.Find(id);
        }

        public void AddProductType(ProductType productType)
        {
            db.ProductTypes.Add(productType);
        }

        public void UpdateProductType(ProductType productType)
        {
            db.Entry(productType).State = EntityState.Modified;
        }

        public void DeleteProductType(int id)
        {
            var productTypeDelete = db.ProductTypes.FirstOrDefault(p => p.ProductTypeId == id);
            db.Entry(productTypeDelete).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}