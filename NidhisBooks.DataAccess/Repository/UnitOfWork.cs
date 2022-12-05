using System;
using System.Collections.Generic;
using System.Text;
using NidhisBooks.DataAccess.Repository.IRepository;
using NidhisBookStore.DataAccess.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NidhisBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork // make the method public toaccess the class
    {
        private readonly ApplicationDbContext _db; // the using statement

        public UnitOfWork(ApplicationDbContext db) // constructor to use DI and inject into the repositories 
        {
            _db = db;

            Category = new CategoryRepository(_db);

            //CoverType = new CoverTypeRepository(_db);

            //Product = new ProductRepository(_db);

            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        //public ICoverTypeRepository CoverType { get; private set; }
        //public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
