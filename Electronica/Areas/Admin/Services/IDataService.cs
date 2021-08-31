using System.Collections.Generic;
using Electronica.Models;

namespace Electronica.Areas.Admin.Services
{
    public interface IDataService
    {
        #region Product

        IList<Product> GetAllProducts();
        Product FindProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

        #endregion

        #region Payment

        IList<Payment> GetAllPayments();
        Payment FindPaymentById(int id);
        void AddPayment(Payment payment);
        void UpdatePayment(Payment payment);
        void DeletePayment(int id);

        #endregion

        #region Order

        IList<Order> GetAllOrders();
        Order FindOrderById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);

        #endregion

        #region ProductCategory

        IList<ProductCategory> GetAllProductCategories();
        ProductCategory FindProductCategoryById(int id);
        void AddProductCategory(ProductCategory productCategory);
        void UpdateProductCategory(ProductCategory productCategory);
        void DeleteProductCategory(int id);

        #endregion

        #region ProductType

        IList<ProductType> GetAllProductTypes();
        ProductType FindProductTypeById(int id);
        void AddProductType(ProductType productType);
        void UpdateProductType(ProductType productType);
        void DeleteProductType(int id);

        #endregion

        
    }
}