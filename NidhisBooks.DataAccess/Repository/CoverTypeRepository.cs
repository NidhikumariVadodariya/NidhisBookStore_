using System;
using System.Collections.Generic;
using System.Text;
using NidhisBooks.Models;
using NidhisBooks.DataAccess.Repository.IRepository;
using NidhisBookStore.DataAccess.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NidhisBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            // throw new NotImplementedException();

            // use the .NET Linq to retrive the first or default category object
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = covertype.Name;
                // _db.SaveChanges();
            }
        }

    }
}
