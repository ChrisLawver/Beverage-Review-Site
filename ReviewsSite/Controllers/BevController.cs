﻿using Microsoft.AspNetCore.Mvc;
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

            Bev bev = new Bev(1, "Sweet and smooth", "Coke", "Soda", "It's good");
            Bev bev2 = new Bev(2, "Crisp and clean", "Pepsi", "Soda", "Not as good as coke");
            return View(bev);
        }


    }
}