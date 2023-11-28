using MuhammedsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetAll(string includeProperties);
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Remove(int id);
        void Save();
        Product Get(int id);
        void Remove(Product objFromDb);
    }
}