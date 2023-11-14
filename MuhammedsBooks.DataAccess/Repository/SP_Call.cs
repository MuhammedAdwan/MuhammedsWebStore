using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsWebStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        //access the db
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; //needed to callled the stired procedures

        //constructor
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }


        //i,plement the ISP_Call interface
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
