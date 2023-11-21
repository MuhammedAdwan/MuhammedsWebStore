using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsBooks.Models;
using MuhammedsWebStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Product product)
        {
            _db.Products.Add(product);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public Product Get(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll(string includeProperties)
        {
            return _db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            var product = _db.Products.Find(id);
            if (product != null)
            {
                _db.Products.Remove(product);
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}