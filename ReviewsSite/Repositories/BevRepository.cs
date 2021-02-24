using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;
using Microsoft.EntityFrameworkCore; 

namespace ReviewsSite.Repositories
{
   
    public class BevRepository : IRepository<Bev>
    {
        private BevContext _db;

        public BevRepository(BevContext db)
        {
            this._db = db;
        }

        public void Create(Bev obj)
        {
            // Bev.Add(obj);
            _db.Bevs.Add(obj);
            _db.SaveChanges();
        }

        public void Delete(Bev obj)
        {
            _db.Bevs.Remove(obj);
            _db.SaveChanges();

        }

        public IEnumerable<Bev> GetALL()
        {
            return _db.Bevs.ToList();
        }

        public Bev GetById(int id)
        {
            return _db.Bevs.Find(id);
        }

        public void Update(Bev obj)
        {
            _db.Bevs.Update(obj);
            _db.SaveChanges();
        }
    }
}
