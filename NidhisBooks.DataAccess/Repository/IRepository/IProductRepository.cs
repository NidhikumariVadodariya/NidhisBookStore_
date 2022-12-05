using System;
using System.Collections.Generic;
using System.Text;
using NidhisBooks.Models;
using System.Linq;
using System.Threading.Tasks;

namespace NidhisBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
