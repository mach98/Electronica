using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Electronica.Models;

namespace Electronica.Repositories
{
    public class GenericUnitOfWork:IDisposable
    {
         // private Online_ShoppingEntities DBEntity = new Online_ShoppingEntities();
        private  ApplicationDbContext db = new ApplicationDbContext();
 
    public IRepository GetRepositoryInstance() where Tbl_EntityType : class
    {
        return new GenericRepository(db);
    }
 
    public void SaveChanges()
    {
        db.SaveChanges();
    }
 
    #region Disposing the Unit of work context ...

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
       if (!this.disposed)
       {
           if (disposing)
           {
             DBEntity.Dispose();
           } 
        }
        this.disposed = true;
     }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}