using MuhammedsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammedsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
