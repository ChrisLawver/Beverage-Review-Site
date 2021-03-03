﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ReviewerName { get; set; }
        public  int Rating { get; set; }
        public int BevId { get; set; }
        public virtual Bev Bev { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
