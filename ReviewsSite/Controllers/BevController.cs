using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;


namespace ReviewsSite.Controllers
{
    public class BevController: Controller
    {
        public ViewResult Index()
        {
            Bev bev = new Bev();

            return View(bev);
        }
    }
}
