using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {


        private BevContext _db;

        public ReviewRepository(BevContext db)
        {
            this._db = db;
        }

        public void Create(Review obj)
        {
            // Bev.Add(obj);
            _db.ReviewList.Add(obj);
            _db.SaveChanges();
        }

        public void Delete(Review obj)
        {
            _db.ReviewList.Remove(obj);
            _db.SaveChanges();

        }

        public IEnumerable<Review> GetALL()
        {
            return _db.ReviewList.ToList();
        }

        public Review GetById(int id)
        {
            return _db.ReviewList.Find(id);
        }

        public void Update(Review obj)
        {
            _db.ReviewList.Update(obj);
            _db.SaveChanges();
        }

        public List<Review> PopulateReviewList()
        {
            var reviews = _db.Set<Review>().ToList();
            if(reviews.Count == 0)
            {
                return new List<Review>();
            }

            return reviews;
        }
    }
 }
