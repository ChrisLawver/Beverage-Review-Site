using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;
using Microsoft.EntityFrameworkCore; 

namespace ReviewsSite.Repositories
{
    public class BevContext : DbContext; 
    public class BevRepository : IRepository<Bev>

    { 
        public void Create(Bev obj)
        {
           // Bev.Add(obj);
        }

        public void Delete(Bev obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bev> GetALL()
        {
            throw new NotImplementedException();
        }

        public Bev GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bev obj)
        {
            throw new NotImplementedException();
        }
    }
}
