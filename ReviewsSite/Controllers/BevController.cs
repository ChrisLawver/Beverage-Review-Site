using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class BevController: Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
