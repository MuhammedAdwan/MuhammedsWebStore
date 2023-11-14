using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        //e.g first column of first row
        T single<T>(string procedurename, DynamicParameters param = null);
        //excute something
        void Execute(string procedurename, DynamicParameters param = null);
        //retrieve the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        //get all of the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //stored procedures that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename,
        DynamicParameters param = null);
    }
}
