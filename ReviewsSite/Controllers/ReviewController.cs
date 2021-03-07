using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;

        }

        public ViewResult Details()
        { 
            var reviewList = reviewRepo.GetALL();
            return View(reviewList);
        }

        public ViewResult Create(int BevId)
        {
            var ReviewList = reviewRepo;
            ViewBag.ReviewList = new SelectList(ReviewList.GetALL(), "Id", "ReviewerName");

            return View(new Review() {BevId = BevId});
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            var ReviewList = reviewRepo;
            ViewBag.ReviewList = new SelectList(ReviewList.GetALL(), "Id", "ReviewerName");
            model.ReviewDate = DateTime.Now;
            reviewRepo.Create(model);

            return View(model);
            
        }


        [HttpPost]
        public ViewResult Update(Review model)
        {
            //var ReviewList = reviewRepo;
            //var beverages = reviewRepo.PopulateReviewList();
            //ViewBag.Beverages = beverages;
            //ViewBag.ReviewList = new SelectList(ReviewList.GetALL(), "Id", "ReviewerName");
            model.ReviewDate = DateTime.Now;
            reviewRepo.Update(model);


            return View(model);
        }

        public ViewResult Update(int id)
        {
            //var ReviewList = reviewRepo;
            var model = reviewRepo.GetById(id);
            //var beverages = reviewRepo.PopulateReviewList();
            //ViewBag.Beverages = beverages;
            //ViewBag.ReviewList = new SelectList(ReviewList.GetALL(), "Id", "ReviewerName");

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetById(id);

            reviewRepo.Delete(review);

            return RedirectToAction("Details", "Bev", new { id = review.BevId});
        }
    }
}
