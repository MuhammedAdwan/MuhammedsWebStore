﻿using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsWebStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //making the method public
    {
        private readonly ApplicationDbContext _db; //the using statment

        public UnitOfWork(ApplicationDbContext db) //constructor to use DI and inject in the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(db);

        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }


        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save() //all changes will be saved when the save method is called at the parent level
        {
            _db.SaveChanges();
        }

    }
}